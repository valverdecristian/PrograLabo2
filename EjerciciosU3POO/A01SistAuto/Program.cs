using BibliotecaDeClases;

namespace A01SistAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Conductores conductor = new Conductores("Martin");
            int dias = 7;

            for (int i = 0; i < dias; i++)
            {
                conductor.AgregarKilometros(10);
            }

            Console.WriteLine(conductor.MostrarInfo());
        }
    }
}