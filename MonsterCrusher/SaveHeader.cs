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

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1280)]
        [FieldOffset(16)]
        public string unknown1;

        [FieldOffset(1296)]
        public UInt32 monsterCount;

        [FieldOffset(1300)]
        public UInt16 dateYear;

        [FieldOffset(1302)]
        public UInt16 dateMonth;

        [FieldOffset(1304)]
        public UInt16 unknown2;

        [FieldOffset(1306)]
        public UInt16 dateDay;

        [FieldOffset(1308)]
        public UInt16 dateHour;

        [FieldOffset(1310)]
        public UInt16 dateMinute;

        [FieldOffset(1312)]
        public UInt32 checksum1;

        [FieldOffset(1316)]
        public UInt32 checksum2;

        [FieldOffset(1320)]
        public UInt32 checksum3;

        [FieldOffset(1324)]
        public UInt32 checksum4;

        [FieldOffset(1328)]
        public UInt16 staminaCurrent;

        [FieldOffset(1332)]
        public UInt16 staminaMaximum;

        [FieldOffset(1336)]
        public UInt16 unknown3;
    }
}
