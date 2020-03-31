using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SaveInventory
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4176)]
        public byte[] unknown1;
    }
}
