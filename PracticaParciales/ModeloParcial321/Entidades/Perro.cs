using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        int _edad;
        bool _esAlfa;

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            :base (nombre, raza)
        {
            _edad = edad;
            _esAlfa = esAlfa;
        }

        public Perro(string nombre, string raza)
            : this (nombre, raza, 0, false)
        {
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DatosCompletos());
            sb.AppendLine($"Edad: {_edad}");
            sb.AppendLine($"Es Alfa: {(_esAlfa ? "Si": "No")}");

            return sb.ToString();
        }

        public static bool operator ==( Perro p1, Perro p2 )
        {
            return p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int (Perro perro)
        {
            return perro._edad;
        }

        public override string ToString()
        {
            return Ficha();
        }

        public override bool Equals(object? obj)
        {
            return obj is Perro perro && perro == this;
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }
}
