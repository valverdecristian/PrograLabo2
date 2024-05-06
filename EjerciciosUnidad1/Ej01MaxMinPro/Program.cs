namespace Ej01MaxMinPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ingresos = 5;
            int suma = 0;
            int numeroMax = int.MinValue;
            int numeroMin = int.MaxValue;
            bool primerIngreso = false;

            for (int i = 0; i < ingresos; i++)
            {
                Console.WriteLine("Ingresa un numero:");
                // ingreso el numero por consola
                string numerosStr = Console.ReadLine();

                // verifico que ese numero se pueda parsear a int
                if (int.TryParse(numerosStr, out int numeroInt))
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
                        if(numeroInt >= numeroMax)
                        {
                            numeroMax = numeroInt;
                        }
                        if(numeroInt <= numeroMin)
                        {
                            numeroMin = numeroInt;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Error volve a ingresa un numero:");
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
