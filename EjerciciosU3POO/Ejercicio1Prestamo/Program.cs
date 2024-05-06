using BibliotecaDeClases;
namespace Ejercicio1Prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la razon social:");
            string inputTitular = Console.ReadLine() ?? string.Empty;
            
            Cuenta cuenta = new Cuenta(inputTitular, 0);

            bool bandera = false;

            while (bandera == false)
            {

                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("1- Ingresar dinero ; 2- Retirar dinero");

                string inputOpcion = Console.ReadLine() ?? string.Empty;

                if (inputOpcion == "1")
                {
                    Console.WriteLine("Cantidad a ingresar en la cuenta:");
                    string inputIngreso = Console.ReadLine() ?? string.Empty;
                    if (decimal.TryParse(inputIngreso, out decimal ingreso))
                    {
                        cuenta.Ingresar(ingreso);
                        Console.WriteLine(cuenta.Mostrar());
                    }
                    bandera = true;
                }
                else if (inputOpcion == "2")
                {
                    Console.WriteLine("Cantidad a retirar de la cuenta:");
                    string inputRetiro = Console.ReadLine() ?? string.Empty;
                    if (decimal.TryParse(inputRetiro, out decimal retiro))
                    {
                        cuenta.Retirar(retiro);
                        Console.WriteLine(cuenta.Mostrar());
                    }
                    bandera = true;
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta");
                }

            }

        }
    }
}