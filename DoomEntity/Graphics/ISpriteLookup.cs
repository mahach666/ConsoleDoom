



using System;
using System.Collections.Generic;

namespace ConsoleDoom
{
    public interface ISpriteLookup
    {
        public SpriteDef this[Sprite sprite] { get; }
    }
}
