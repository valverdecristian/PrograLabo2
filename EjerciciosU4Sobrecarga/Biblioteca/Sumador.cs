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

        public void Sumar(long num1, long num2)
        {
            cantidadSumas++;
            long resultado = num1 + num2;
            Console.WriteLine($"La suma de {num1} y {num2} es: {resultado}");
        }

        public void Sumar(string cadena1, string cadena2)
        {
            cantidadSumas++;
            string resultado = cadena1 + cadena2;
            Console.WriteLine($"Concatenación de '{cadena1}' y '{cadena2}' es: {resultado}");
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return (int)sumador1 == (int)sumador2;
        }
    }
}