using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class SpaceTakenException : Exception
    {
        public SpaceTakenException(int i) : base("Место" + i + "занято")
        { }
    }
}
