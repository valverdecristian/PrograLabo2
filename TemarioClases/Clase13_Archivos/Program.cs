using EntidadesArchivos;

namespace Clase13_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Archivo.ruta);
            try
            {
                Archivo.Escribir();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}