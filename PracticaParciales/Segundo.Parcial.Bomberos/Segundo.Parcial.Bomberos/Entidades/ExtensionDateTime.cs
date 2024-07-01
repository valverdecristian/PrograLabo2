using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Extender la clase DateTime para calcular la diferencia en segundos entre una fecha de inicio y una fecha de fin:
    public static class ExtensionDateTime
    {
        // el this en el 1er parametro convierte este metodo estatico en un metodo de extension
        public static double CalcularDiferenciaEnSegundos(this DateTime inicio, DateTime fin)
        {
            return (fin - inicio).TotalSeconds;
        }
    }
}
