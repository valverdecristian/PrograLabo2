namespace EjercicioA01Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En una aplicación de consola, desarrollar un método estático que calcule el Factorial de un número dado.
            Console.WriteLine("Ingresar un numero:");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero))
            {
                int resultado = Factorial(numero);
                Console.WriteLine($"{numero}! = {resultado}");
            }
            else
            {
                Console.WriteLine("no se pudo realizar la operacion");
            }
        }

        public static int Factorial(int numero)
        {
            int resultado = 1;
            for (int i = numero; i > 1; i--)
            {
                if (resultado > int.MaxValue / i)
                {
                    return -1;
                }
                resultado *= i;
            }

            return resultado;
        }
    }
}