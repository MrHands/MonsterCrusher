using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SaveMonster
    {
        [FieldOffset(0)]
        public UInt32 unknown1;

        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String imageFace;

        [FieldOffset(68)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String imageTatie;

        [FieldOffset(132)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String imageFaceMini1;

        [FieldOffset(196)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String imageFaceMini2;

        [FieldOffset(260)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String imageIcon;

        [FieldOffset(324)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public String unknown2;

        [FieldOffset(356)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public String unknown3;

        [FieldOffset(388)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String name;

        [FieldOffset(452)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public String race1;

        [FieldOffset(484)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public String race2;

        [FieldOffset(516)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 448)]
        public byte[] unknown5;

        [FieldOffset(964)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] unknown6;

        // bunch of numbers with a checksum?

        [FieldOffset(1220)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] unknown7;

        [FieldOffset(1476)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1276)]
        public byte[] unknown8;

        [FieldOffset(2752)]
        public UInt32 unknown9;

        [FieldOffset(2756)]
        public UInt32 staminaCurrent;

        [FieldOffset(2760)]
        public UInt32 mentalCurrent;

        [FieldOffset(2764)]
        public UInt32 staminaMaximum;

        [FieldOffset(2768)]
        public UInt32 mentalMaximum;

        [FieldOffset(2772)]
        public UInt32 pricePurchase;

        [FieldOffset(2776)]
        public UInt32 priceSale;

        [FieldOffset(2780)]
        public UInt32 pleasure;

        [FieldOffset(2784)]
        public UInt32 shameMaximum;

        [FieldOffset(2788)]
        public UInt32 shameCurrent;

        [FieldOffset(2792)]
        public UInt32 prideMaximum;

        [FieldOffset(2796)]
        public UInt32 prideCurrent;

        [FieldOffset(2800)]
        public UInt32 unknown12; // 100?

        [FieldOffset(2804)]
        public UInt32 unknown13;

        [FieldOffset(2808)]
        public UInt32 unknown14;

        [FieldOffset(2812)]
        public UInt32 unknown15;

        [FieldOffset(2816)]
        public UInt32 unknown16;

        [FieldOffset(2820)]
        public UInt32 unknown17;

        [FieldOffset(2824)]
        public UInt32 unknown18;

        [FieldOffset(2828)]
        public UInt32 unknown19;

        [FieldOffset(2832)]
        public UInt32 squeezedDry;

        [FieldOffset(2836)]
        public UInt32 unknown28;

        [FieldOffset(2840)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String imagePlay1;

        [FieldOffset(2900)]
        public UInt32 unknown29;

        [FieldOffset(2904)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public String imagePlay2;

        [FieldOffset(2964)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] unknown21;

        [FieldOffset(3000)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1236)]
        public byte[] unknown22;

        [FieldOffset(4236)]
        public UInt32 statObedience;

        [FieldOffset(4240)]
        public UInt32 statLewdness;

        [FieldOffset(4244)]
        public UInt32 statTechnique;

        [FieldOffset(4248)]
        public UInt32 statAffection;

        [FieldOffset(4252)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] unknown23;

        [FieldOffset(4280)]
        public UInt32 prostitutionCount;

        [FieldOffset(4284)]
        public UInt32 moneyEarned;

        [FieldOffset(4288)]
        public UInt32 unknown24;

        [FieldOffset(4292)]
        public UInt32 unknown25;

        [FieldOffset(4296)]
        public UInt32 unknown26;

        [FieldOffset(4300)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] unknown27;
    }
}
