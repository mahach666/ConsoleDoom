



using System;

namespace ConsoleDoom
{
    public static partial class DoomInfo
    {
        public static class PowerDuration
        {
            public static readonly int Invulnerability = 30 * GameConst.TicRate;
            public static readonly int Invisibility = 60 * GameConst.TicRate;
            public static readonly int Infrared = 120 * GameConst.TicRate;
            public static readonly int IronFeet = 60 * GameConst.TicRate;
        }
    }
}
