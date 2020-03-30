using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SaveHeader
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string identifier;

        [FieldOffset(8)]
        public UInt32 days;

        [FieldOffset(12)]
        public UInt32 money;
    }
}
