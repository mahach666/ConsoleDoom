using System.Collections.Generic;

namespace ConsoleDoom.DoomEntity.Graphics
{
    public sealed class PatchCache
    {
        private Wad wad;
        private Dictionary<string, Patch> cache;

        public PatchCache(Wad wad)
        {
            this.wad = wad;

            cache = new Dictionary<string, Patch>();
        }

        public Patch this[string name]
        {
            get
            {
                Patch patch;
                if (!cache.TryGetValue(name, out patch))
                {
                    patch = Patch.FromWad(wad, name);
                    cache.Add(name, patch);
                }
                return patch;
            }
        }

        public int GetWidth(string name)
        {
            return this[name].Width;
        }

        public int GetHeight(string name)
        {
            return this[name].Height;
        }
    }
}
