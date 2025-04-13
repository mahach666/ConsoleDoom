namespace ConsoleDoom.DoomEntity.World
{
    public sealed class WeaponInfo
    {
        private AmmoType ammo;
        private MobjState upState;
        private MobjState downState;
        private MobjState readyState;
        private MobjState attackState;
        private MobjState flashState;

        public WeaponInfo(
            AmmoType ammo,
            MobjState upState,
            MobjState downState,
            MobjState readyState,
            MobjState attackState,
            MobjState flashState)
        {
            this.ammo = ammo;
            this.upState = upState;
            this.downState = downState;
            this.readyState = readyState;
            this.attackState = attackState;
            this.flashState = flashState;
        }

        public AmmoType Ammo
        {
            get => ammo;
            set => ammo = value;
        }

        public MobjState UpState
        {
            get => upState;
            set => upState = value;
        }

        public MobjState DownState
        {
            get => downState;
            set => downState = value;
        }

        public MobjState ReadyState
        {
            get => readyState;
            set => readyState = value;
        }

        public MobjState AttackState
        {
            get => attackState;
            set => attackState = value;
        }

        public MobjState FlashState
        {
            get => flashState;
            set => flashState = value;
        }
    }
}
