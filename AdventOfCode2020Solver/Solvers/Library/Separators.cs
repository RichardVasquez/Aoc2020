using System;

namespace AdventOfCode.Library
{
    [Flags]
    public enum Separators
    {
        None = 0,
        WhiteSpace = 1,
        NewLines = 2,
        All = 3    
    }
}
