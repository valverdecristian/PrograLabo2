using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Carta:Papel
    {
        public string sello;

        public Carta(string tipo, int cantidadHojas, string sello): base(tipo, cantidadHojas)
        {
            this.sello = sello;
        }

        public string AbrirCarta()
        {
            return "Abrir Carta";
        }

        public string EnviarMensaje()
        {
            return "Enviar Mensaje";
        }
    }
}
