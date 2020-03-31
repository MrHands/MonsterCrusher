using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SaveClient
    {
        [FieldOffset(0)]
        public UInt32 unknown1;

        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public String imageCustomer;

        [FieldOffset(260)]
        public UInt32 checksum1;

        [FieldOffset(264)]
        public UInt32 checksum2;

        [FieldOffset(268)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public byte[] unknown2;

        [FieldOffset(324)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String name;

        [FieldOffset(388)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String unknown3;

        [FieldOffset(452)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public String description;

        [FieldOffset(580)]
        public UInt32 energyMaximum;

        [FieldOffset(584)]
        public UInt32 unknown4; // 100

        [FieldOffset(588)]
        public UInt32 level;

        [FieldOffset(592)]
        public UInt32 technique;

        [FieldOffset(596)]
        public UInt32 unknown5; // 0

        [FieldOffset(600)]
        public UInt32 unknown6; // 0

        [FieldOffset(604)]
        public UInt32 unknown7; // 4

        [FieldOffset(608)]
        public UInt32 unknown8; // 3600

        [FieldOffset(612)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] unknown9;

        [FieldOffset(644)]
        public UInt32 unknown10; // 3

        [FieldOffset(648)]
        public UInt32 checksum3;

        [FieldOffset(652)]
        public UInt32 checksum4;

        [FieldOffset(656)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1532)]
        public byte[] unknown11;

        [FieldOffset(2188)]
        public UInt32 money;

        [FieldOffset(2192)]
        public UInt32 energyCurrent;

        [FieldOffset(2196)]
        public UInt32 unknown12; // 100

        [FieldOffset(2200)]
        public UInt32 unknown13; // 1

        [FieldOffset(2204)]
        public UInt32 unknown14; // 0

        [FieldOffset(2208)]
        public UInt32 unknown15; // 4

        [FieldOffset(2212)]
        public UInt32 unknown16; // 2

        [FieldOffset(2216)]
        public UInt32 unknown17; // 4

        [FieldOffset(2220)]
        public UInt32 unknown18; // 82

        [FieldOffset(2224)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] unknown19;
    }
}
