using System;

namespace Ships
{
    class SpaceTakenException : Exception
    {
        public SpaceTakenException(int i) : base("Место" + i + "занято")
        { }
    }
}
