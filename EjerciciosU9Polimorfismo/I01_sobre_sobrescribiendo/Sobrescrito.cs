using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_sobre_sobrescribiendo
{
    public class Sobrescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object? obj)
        {
            return obj is Sobrescrito;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
