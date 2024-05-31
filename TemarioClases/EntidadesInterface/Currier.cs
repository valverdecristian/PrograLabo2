using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Currier:Persona,IMensaje
    {
        public Currier(string nombre, string apellido, string dni): base (nombre, apellido, dni)
        {
            
        }

        public string EnviarMensaje()
        {
            return "Enviar";
        }
    }
}
