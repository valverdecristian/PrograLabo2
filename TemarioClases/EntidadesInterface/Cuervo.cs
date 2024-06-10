using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInterface
{
    public class Cuervo : AnimalVolador, IMensaje, IEncriptado
    {
        public Cuervo(string nombre) : base(nombre) { }

        public string EnviarMensaje()
        {
            return "Le declaramos la guerra al gobierno mundial";
        }

        public int Prueba()
        {
            throw new NotImplementedException();
        }

        string IEncriptado.EnviarMensaje()
        {
            return "La fruta se llama Ito Ito no mi: Model Nika";
        }
    }

    // para usar una "imterfaz explicita":
    // metodo sin modificador de acceso y el nombre de la interfaz punto nombre del metodo
    // string IMensaje.EnviarMensaje() { return "enviado explicitamente"; }
    // se usan en problemas de ambiguedad o querer ocultar la implementacion y tener que castearla
}
