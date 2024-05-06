using Funciones;

namespace Ejercicio1ValidadorRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ingresos = 10;
            int suma = 0;
            int numeroMax = int.MinValue;
            int numeroMin = int.MaxValue;
            int rangoMin = -100;
            int rangoMax = 100;
            bool primerIngreso = false;

            for (int i = 0; i < ingresos; i++)
            {
                Console.WriteLine("Ingresa un numero que este entre -100 y 100:");
                string numerosStr = Console.ReadLine();

                if (int.TryParse(numerosStr, out int numeroInt) && Validador.Validar(numeroInt, rangoMin, rangoMax))
                {
                    suma += numeroInt;

                    if (primerIngreso == false)
                    {
                        numeroMax = numeroInt;
                        numeroMin = numeroInt;
                        primerIngreso = true;
                    }
                    else
                    {
                        if (numeroInt >= numeroMax)
                        {
                            numeroMax = numeroInt;
                        }
                        if (numeroInt <= numeroMin)
                        {
                            numeroMin = numeroInt;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Error");
                    i--;
                }

            }

            float promedio = (float)suma / ingresos;
            Console.WriteLine($"el valor maximo es: {numeroMax}");
            Console.WriteLine($"el valor minimo es: {numeroMin}");
            Console.WriteLine($"el promedio es: {promedio}");
        }
    }
}