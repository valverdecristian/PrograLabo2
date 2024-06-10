using System.Text.Json;

namespace EntidadesArchivos
{
    public static class SerializadoraJson // serializadoraJson
    {
        static string ruta;

        static SerializadoraJson()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion2";
        }

        public static void Escribir(Mascota mascota)
        {
            // se le cambia la extension a .json
            string completa = ruta + @"\Serializadora_Mascota.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                // esto nos da un string
                string objetoJson = JsonSerializer.Serialize(mascota);

                File.WriteAllText(completa, objetoJson);
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static Mascota Leer()
        { 
            string completa = ruta + @"\Serializadora_Mascota.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string archivoJson = File.ReadAllText(completa);
                
                return JsonSerializer.Deserialize<Mascota>(archivoJson);

            }
            catch (Exception)
            {

                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
