using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    public class Save
    {
        public SaveHeader header;
        public List<SaveMonster> monstersSale = new List<SaveMonster>();
        public List<SaveMonster> monstersOwned = new List<SaveMonster>();

        public bool Load(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            ReadStruct<SaveHeader>(reader, ref header);

            for (int i = 0; i < 6; ++i)
            {
                SaveMonster offer = new SaveMonster();
                ReadStruct<SaveMonster>(reader, ref offer);
                monstersSale.Add(offer);
            }

            // 96728

            reader.BaseStream.Seek(241428, SeekOrigin.Begin);

            for (int i = 0; i < header.monsterCount; ++i)
            {
                SaveMonster owned = new SaveMonster();
                ReadStruct<SaveMonster>(reader, ref owned);
                monstersOwned.Add(owned);
            }

            for (;;)
            {
                SaveMonster unused = new SaveMonster();
                ReadStruct<SaveMonster>(reader, ref unused);
                if (!unused.imageIcon.EndsWith(".tga"))
                {
                    break;
                }

                monstersOwned.Add(unused);
            }

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
