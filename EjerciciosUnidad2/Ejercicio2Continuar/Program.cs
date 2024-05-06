using Funciones;

namespace Ejercicio2Continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bandera;

            do
            {
                Console.WriteLine("Ingrese el primer operando");
                string primerInput = Console.ReadLine();

                Console.WriteLine("Ingrese el segundo operando");
                string segundoInput = Console.ReadLine();

                if(int.TryParse(primerInput, out int primerValor) && int.TryParse(segundoInput, out int segundoValor))
                {
                    int sumatoria = Calculadora.Sumar(primerValor, segundoValor);

                    Console.WriteLine($"la suma de {primerValor} y {segundoValor} es: {sumatoria}");
                }
                else
                {
                    Console.WriteLine("No se pudo realizar la sumatoria");
                }
                
                Console.WriteLine("Desea continuar? apretar 's' para confirmar o cualquier tecla para terminar");

                string respuesta = Console.ReadLine();
                
                bandera = Validador.ValidarRespuesta(respuesta.ToUpper());

            } while (bandera);
        }
    }
}