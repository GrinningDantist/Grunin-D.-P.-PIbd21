using System;

namespace Ships
{
    class ShipAlreadyExistsException : Exception
    {
        public ShipAlreadyExistsException() : base("В доках уже есть такой корабль")
        { }
    }
}
