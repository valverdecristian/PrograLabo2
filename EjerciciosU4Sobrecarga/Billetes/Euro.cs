using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
    }
}
