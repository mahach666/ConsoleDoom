namespace ConsoleDoom.Audio
{
    public interface IMusic
    {
        void StartMusic(Bgm bgm, bool loop);

        public int MaxVolume { get; }
        public int Volume { get; set; }
    }
}
