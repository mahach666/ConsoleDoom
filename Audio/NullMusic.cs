namespace ConsoleDoom.Audio
{
    public sealed class NullMusic : IMusic
    {
        private static NullMusic instance;

        public static NullMusic GetInstance()
        {
            if (instance == null)
            {
                instance = new NullMusic();
            }

            return instance;
        }

        public void StartMusic(Bgm bgm, bool loop)
        {
        }

        public int MaxVolume
        {
            get
            {
                return 15;
            }
        }

        public int Volume
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }
    }
}
