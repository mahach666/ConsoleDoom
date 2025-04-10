


using System;
using System.Collections.Generic;

namespace ManagedDoom
{
    public interface IFlatLookup : IReadOnlyList<Flat>
    {
        int GetNumber(string name);
        public Flat this[string name] { get; }
        public int SkyFlatNumber { get; }
        public Flat SkyFlat { get; }
    }
}
