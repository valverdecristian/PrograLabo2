using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VeiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

    }
}
