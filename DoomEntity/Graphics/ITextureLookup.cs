using System.Collections.Generic;

namespace ConsoleDoom.DoomEntity.Graphics
{
    public interface ITextureLookup : IReadOnlyList<Texture>
    {
        int GetNumber(string name);
        Texture this[string name] { get; }
        public int[] SwitchList { get; }
    }
}
