



using System;

namespace ConsoleDoom
{
    [Flags]
    public enum PathTraverseFlags
    {
        AddLines = 1,
        AddThings = 2,
        EarlyOut = 4
    }
}
