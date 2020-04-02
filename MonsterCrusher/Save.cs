using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    public class Ref<T> where T : struct
    {
        public T Value { get; set; }
    }

    public class Save
    {
        public SaveHeader header;
        public List<Ref<SaveClient>> clients = new List<Ref<SaveClient>>();
        public List<Ref<SaveMonster>> monstersSale = new List<Ref<SaveMonster>>();
        public List<Ref<SaveMonster>> monstersOwned = new List<Ref<SaveMonster>>();
        public SaveInventory inventory = new SaveInventory();
        public byte[] padding1;
        public byte[] padding2;
        public byte[] padding3;
        public byte[] padding4;

        public bool LoadFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            ReadStruct<SaveHeader>(reader, ref header);

            // monsters for sale

            for (int i = 0; i < 6; ++i)
            {
                var offer = new Ref<SaveMonster>() { Value = new SaveMonster() };
                ReadStruct<SaveMonster>(reader, offer);
                monstersSale.Add(offer);
            }

            padding1 = ReadPadding(reader, 92552 - reader.BaseStream.Position);

            // inventory

            ReadStruct<SaveInventory>(reader, ref inventory);
            padding2 = ReadPadding(reader, 96728 - reader.BaseStream.Position);

            // clients

            for (; ; )
            {
                var client = new Ref<SaveClient>() { Value = new SaveClient() };
                ReadStruct<SaveClient>(reader, client);
                if (!client.Value.imageCustomer.EndsWith(".tga"))
                {
                    reader.BaseStream.Seek(Marshal.SizeOf(typeof(SaveClient)) * -1, SeekOrigin.Current);

                    break;
                }

                clients.Add(client);
            }

            padding3 = ReadPadding(reader, 241428 - reader.BaseStream.Position);

            // monsters owned

            for (; ; )
            {
                var unused = new Ref<SaveMonster>() { Value = new SaveMonster() };
                ReadStruct<SaveMonster>(reader, unused);
                if (!unused.Value.imageIcon.EndsWith(".tga"))
                {
                    reader.BaseStream.Seek(Marshal.SizeOf(typeof(SaveMonster)) * -1, SeekOrigin.Current);

                    break;
                }

                monstersOwned.Add(unused);
            }

            padding4 = ReadPadding(reader, reader.BaseStream.Length - reader.BaseStream.Position);

            return true;
        }

        public void SaveToStream(Stream stream)
        {
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(GetBytes(header));

            foreach (var m in monstersSale)
            {
                writer.Write(GetBytes(m.Value));
            }

            writer.Write(padding1);

            writer.Write(GetBytes(inventory));

            writer.Write(padding2);

            foreach (var c in clients)
            {
                writer.Write(GetBytes(c.Value));
            }

            writer.Write(padding3);

            foreach (var m in monstersOwned)
            {
                writer.Write(GetBytes(m.Value));
            }

            writer.Write(padding4);
        }

        private byte[] GetBytes<Type>(Type data)
        {
            int length = Marshal.SizeOf(data);
            IntPtr ptr = Marshal.AllocHGlobal(length);
            byte[] myBuffer = new byte[length];

            Marshal.StructureToPtr(data, ptr, true);
            Marshal.Copy(ptr, myBuffer, 0, length);
            Marshal.FreeHGlobal(ptr);

            return myBuffer;
        }

        private byte[] ReadPadding(BinaryReader reader, long count)
        {
            byte[] readBuffer = new byte[count];
            readBuffer = reader.ReadBytes((int)count);

            return readBuffer;
        }

        private bool ReadStruct<Type>(BinaryReader reader, Ref<Type> target) where Type : struct
        {
            int count = Marshal.SizeOf(typeof(Type));
            byte[] readBuffer = new byte[count];
            readBuffer = reader.ReadBytes(count);

            GCHandle handle = GCHandle.Alloc(readBuffer, GCHandleType.Pinned);
            target.Value = (Type)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Type));
            handle.Free();

            return true;
        }

        private bool ReadStruct<Type>(BinaryReader reader, ref Type target)
        {
            int count = Marshal.SizeOf(typeof(Type));
            byte[] readBuffer = new byte[count];
            readBuffer = reader.ReadBytes(count);

            GCHandle handle = GCHandle.Alloc(readBuffer, GCHandleType.Pinned);
            target = (Type)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Type));
            handle.Free();

            return true;
        }
    }
}
