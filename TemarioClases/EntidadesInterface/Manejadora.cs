using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Manejadora
    {
        public string MostrarMensaje(IMensaje mensaje)
        {
            return mensaje.EnviarMensaje();
        }
    }
}
