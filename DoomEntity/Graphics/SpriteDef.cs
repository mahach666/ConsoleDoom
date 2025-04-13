namespace ConsoleDoom.DoomEntity.Graphics
{
    public sealed class SpriteDef
    {
        private SpriteFrame[] frames;

        public SpriteDef(SpriteFrame[] frames)
        {
            this.frames = frames;
        }

        public SpriteFrame[] Frames => frames;
    }
}
