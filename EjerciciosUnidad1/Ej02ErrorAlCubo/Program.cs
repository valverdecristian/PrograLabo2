namespace Ej02ErrorAlCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;

            do
            {
                Console.WriteLine("Ingresar un numero mayor que cero:");

                string numeroStr = Console.ReadLine();
                bool estado = double.TryParse(numeroStr, out numero);

                if (estado && numero > 0)
                {
                    cuadrado = Math.Pow(numero, 2);
                    cubo = Math.Pow(numero, 3);
                    Console.WriteLine($"El cuadrado de {numero} es {cuadrado}");
                    Console.WriteLine($"El cubo de {numero} es {cubo}");

                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numero <= 0);

            
        }
    }
}