namespace EntidadesArchivos
{
    public static class Archivo
    {
        public static string ruta;

        static Archivo()
        {
            // Environment es una clase estatica que nos da info del sistema
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // devuelve la ruta de nuestro escritorio
            ruta += @"\Archivos"; // C:\Users\crizt\OneDrive\Escritorio\Archivos
        }

        public static void Escribir()
        {
            // va a romper sin try-catch [porque no existe el archivo]

            // le damos la extension nosotros (txt)
            string completa = ruta + @"\Laboratorio.txt"; // esta ruta no existe
            
            try
            {
                // este if se encarga de ver si existe o no ese directorio
                if(!Directory.Exists( ruta ))
                {
                    Directory.CreateDirectory( ruta );
                }

                // el using cierra el archivo [evita errores nuestro]
                using (StreamWriter sw = new StreamWriter(completa))
                                    // sin el true pisa lo anterior (completa, true)
                {
                    // escribiendo y creando el archivo
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
                // variable para guardar los datos
                string datos = string.Empty;

                // fijarnos si existe el directorio
                if(Directory.Exists( ruta ) )
                {
                    string completa = ruta + @"\Laboratorio.txt";

                    using (StreamReader sr = new StreamReader(completa))
                    {
                        // porque streamReader lee linea a linea
                        string linea;

                        datos = sr.ReadToEnd(); // para la cursada sirve esto

                        // leer linea a linea
                        //while ((linea = sr.ReadLine()) is not null)
                        //{
                        //    datos += linea;
                        //}
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