namespace EntidadesArchivos
{
    public static class Archivo
    {
        public static string ruta;

        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }

        public static void Escribir()
        {
            // va a romper sin try-catch

            string completa = ruta + @"\Laboratorio.txt";
            
            try
            {
                if(!Directory.Exists( ruta ))
                {
                    Directory.CreateDirectory( ruta );
                }

                // clase que va a escribir en el archivo
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    sw.WriteLine("Fecha");
                    sw.WriteLine(DateTime.Now.ToString());
                }
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
                string datos = string.Empty;

                if(Directory.Exists( ruta ) )
                {
                    string completa = ruta + @"\Laboratorio.txt";

                    using (StreamReader sr = new StreamReader(completa))
                    {
                        string linea;

                        // datos = sr.ReadToEnd();

                        while ((linea = sr.ReadLine()) != null)
                        { 
                            datos += linea;
                        }
                    }
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