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

        public bool Load(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);

            int count = Marshal.SizeOf(typeof(SaveHeader));
            byte[] readBuffer = new byte[count];
            readBuffer = reader.ReadBytes(count);

            GCHandle handle = GCHandle.Alloc(readBuffer, GCHandleType.Pinned);

            header = (SaveHeader)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(SaveHeader));

            handle.Free();

            return true;
        }
    }
}
