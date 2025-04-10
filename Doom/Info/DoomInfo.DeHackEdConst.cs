



using System;

namespace ManagedDoom
{
    public static partial class DoomInfo
    {
        public static class DeHackEdConst
        {
            public static int InitialHealth { get; set; } = 100;
            public static int InitialBullets { get; set; } = 50;
            public static int MaxHealth { get; set; } = 200;
            public static int MaxArmor { get; set; } = 200;
            public static int GreenArmorClass { get; set; } = 1;
            public static int BlueArmorClass { get; set; } = 2;
            public static int MaxSoulsphere { get; set; } = 200;
            public static int SoulsphereHealth { get; set; } = 100;
            public static int MegasphereHealth { get; set; } = 200;
            public static int GodModeHealth { get; set; } = 100;
            public static int IdfaArmor { get; set; } = 200;
            public static int IdfaArmorClass { get; set; } = 2;
            public static int IdkfaArmor { get; set; } = 200;
            public static int IdkfaArmorClass { get; set; } = 2;
            public static int BfgCellsPerShot { get; set; } = 40;
            public static bool MonstersInfight { get; set; } = false;
        }
    }
}
