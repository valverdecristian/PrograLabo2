using Funciones;

namespace Ejercicio6Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("el area de que figura desea calcular?");
            Console.WriteLine("1 - Cuadrado, 2 - Triangulo, 3 - Circulo");

            string input = Console.ReadLine();

            if(input == "1")
            {
                Console.WriteLine("Ingresar la longitud del cuadrado");
                string inputCuadrado = Console.ReadLine();
                if(double.TryParse(inputCuadrado, out double valorIngresado))
                {
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCuadrado(valorIngresado));
                }
                else
                {
                    Console.WriteLine("NO SE PUEDO REALIZAR EL CALCULO");
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("Ingresar la base del triangulo");
                string inputBase = Console.ReadLine();
                Console.WriteLine("Ingresar la altura del triangulo");
                string inputAltura = Console.ReadLine();

                if (double.TryParse(inputBase, out double valorBase) && double.TryParse(inputAltura, out double valorAltura))
                {
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaTriangulo(valorBase, valorAltura));
                }
                else
                {
                    Console.WriteLine("NO SE PUEDO REALIZAR EL CALCULO");
                }
            }
            else if (input == "3")
            {
                Console.WriteLine("Ingresar el radio del circulo");
                string inputRadio = Console.ReadLine();
                if (double.TryParse(inputRadio, out double valorIngresado))
                {
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCirculo(valorIngresado));
                }
                else
                {
                    Console.WriteLine("NO SE PUEDO REALIZAR EL CALCULO");
                }
            }
            else
            {
                Console.WriteLine("NO SE INGRESO UN NUMERO DE LA LISTA");
            }
        }
    }
}