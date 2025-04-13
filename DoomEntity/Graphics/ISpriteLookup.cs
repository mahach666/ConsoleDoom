namespace ConsoleDoom.DoomEntity.Graphics
{
    public interface ISpriteLookup
    {
        public SpriteDef this[Sprite sprite] { get; }
    }
}
