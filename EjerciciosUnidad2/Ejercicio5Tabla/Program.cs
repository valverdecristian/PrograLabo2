using Microsoft.VisualBasic;
using System.Text;

namespace Ejercicio5Tabla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            //Crear una aplicación de consola que permita al usuario ingresar un número entero.
            //Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación
            //de ese número en formato string.
            //Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
            //Mostrar en la consola el resultado.
            #endregion

            Console.WriteLine("Ingrese un numero");
            string input = Console.ReadLine();

            Console.WriteLine(TablaDeMultiplicar(input));
        }

        public static string TablaDeMultiplicar(string input)
        {
            StringBuilder sb = new();

            if (int.TryParse(input, out int numero))
            {
                sb.AppendLine($"La tabla de multiplicar de {numero}:");
                for (int i = 1; i < 10; i++)
                {
                    int resultado = numero * i;
                    sb.AppendLine($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                sb.AppendLine("No se pudo realizar la tabla de multiplicar");
            }

            return sb.ToString();
        }
    }
}