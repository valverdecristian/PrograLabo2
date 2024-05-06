using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotzRespectoDolar());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
    }

}
