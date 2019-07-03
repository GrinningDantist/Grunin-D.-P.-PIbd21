using System;

namespace Ships
{
    class DocksOverflowException : Exception
    {
        public DocksOverflowException() : base("В доках нет свободных мест")
        { }
    }
}
