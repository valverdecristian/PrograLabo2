using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DatosCompletos());

            return sb.ToString();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return g1.Nombre == g2.Nombre && g1.Raza == g2.Raza;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return Ficha();
        }

        public override bool Equals(object? obj)
        {
            return obj is Gato otroGato && otroGato == this;
        }
    }
}
