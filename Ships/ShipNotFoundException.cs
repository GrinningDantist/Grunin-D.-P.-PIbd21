using System;

namespace Ships
{
    class ShipNotFoundException : Exception
    {
        public ShipNotFoundException(int i) : base("Не найден корабль по месту " + i)
        { }
    }
}
