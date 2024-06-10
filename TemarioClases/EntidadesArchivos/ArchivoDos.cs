using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesArchivos
{
    public class ArchivoDos // preferible usar este metodo para trabajar
    {
        public static string ruta;

        static ArchivoDos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos"; // C:\Users\crizt\OneDrive\Escritorio\Archivos
        }

        public static void Escribir()
        {
            string completa = ruta + @"\Laboratorio2ParteDos" + DateTime.Now.ToString("HH_mm_ss") + ".txt";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string datos = "Hello there, hubo un errror en la linea 32";

                // otra forma de escribir
                // no es necesario el using, File lo resuelve
                File.WriteAllText(completa, datos);
            }
            catch (Exception)
            {

                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static string Leer()
        {
            try
            {
                // variable para guardar los datos
                string datos = string.Empty;

                // fijarnos si existe el directorio
                if (Directory.Exists(ruta))
                {
                    string completa = ruta + @"\Laboratorio.txt";

                    // leer
                    datos = File.ReadAllText(completa);
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }
    }
}
