using Funciones;
using System.Text;

namespace Ejercicio4Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar dos numeros y un operador ( +, -, * o / )");
            
            Console.WriteLine("Ingrese el primer operando");
            string primerInput = Console.ReadLine();
            
            Console.WriteLine("Ingrese el segundo operando");
            string segundoInput = Console.ReadLine();
            
            Console.WriteLine("Ingrese el operador");
            string operador = Console.ReadLine();
            
            if (int.TryParse(primerInput, out int primerOperando) && int.TryParse(segundoInput, out int segundoOperando))
            {
                int resultado = Calculadora.Calcular(primerOperando, segundoOperando, operador);
                Console.WriteLine($"{primerOperando} {operador} {segundoOperando} = {resultado}");
            }
            else
            {
                Console.WriteLine("NO SE PUDO REALIZAR LA OPERACION");
            }
        }
    }

}