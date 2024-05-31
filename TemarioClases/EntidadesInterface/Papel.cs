using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Papel
    {
        protected string tipo;
        protected int cantHojas;

        public Papel(string tipo, int cantHojas)
        {
            this.tipo = tipo;
            this.cantHojas = cantHojas;
        }
    }
}
