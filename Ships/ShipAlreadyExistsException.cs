using System;

namespace Ships.docksgame.exceptions
{
    class ShipAlreadyExistsException : Exception
    {
        public ShipAlreadyExistsException() : base("В доках уже есть такой корабль")
        { }
    }
}
