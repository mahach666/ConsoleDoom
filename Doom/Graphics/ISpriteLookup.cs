



using System;
using System.Collections.Generic;

namespace ManagedDoom
{
    public interface ISpriteLookup
    {
        public SpriteDef this[Sprite sprite] { get; }
    }
}
