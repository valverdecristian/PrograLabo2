using System.Data.Common;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas) // setear con el valor que le paso
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador(): this(0)
        {
            // inicializa "cantidadSumas" en 0
        }

        public long Sumar(long num1, long num2)
        {
            cantidadSumas++;
            return num1 + num2;
        }

        public string Sumar(string cadena1, string cadena2)
        {
            cantidadSumas++;
            return cadena1 + cadena2;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return (int)sumador1 + (int)sumador2;
        }

        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return (int)sumador1 == (int)sumador2;
        }
    }
}