namespace Ej06Bisiesto
{
    internal class Program
    {
        public static bool EsBisiesto(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año para verificar si es bisiesto:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int year))
            {
                if (EsBisiesto(year))
                {
                    Console.WriteLine($"{year} es un año bisiesto.");
                }
                else
                {
                    Console.WriteLine($"{year} no es un año bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un año válido.");
            }
        }
    }
}