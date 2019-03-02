using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class ShipNotFoundException : Exception
    {
        public ShipNotFoundException(int i) : base("Не найден корабль по месту " + i)
        { }
    }
}
