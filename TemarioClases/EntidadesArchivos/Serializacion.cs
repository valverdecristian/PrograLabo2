using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntidadesArchivos
{
    public static class Serializacion // se podria hacer generico <T>
    {
        // para la serializacion se necesita un constructor sin parametros
        // y vamos a necesitar atributos o propiedades publicas
        // autoproperties: las propiedades pueden trabajarse como atributos

        public static string ruta;

        static Serializacion()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos-Serializacion1";
        }

        public static void EscribirLista(List<Personaje> personajes)
        {
            string completa = ruta + @"\Serializadora_Lista.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));
                    xmlSerializer.Serialize(sw, personajes);
                }

            }
            catch (Exception)
            {

                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static void Escribir(Personaje pj) // Escribir(T pj)
        {
            string completa = ruta + @"\Serializadora_.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using(StreamWriter sw = new StreamWriter(completa))
                {
                    // lo nuevo
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    xmlSerializer.Serialize(sw, pj);
                }

            }
            catch (Exception e)
            {

                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static Personaje Leer()
        {
            Personaje pj = null;
            string completa = ruta + @"\Serializadora_.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sw = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    pj = (Personaje)xmlSerializer.Deserialize(sw);
                }

                return pj;

            }
            catch (Exception)
            {

                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static List<Personaje> LeerLista()
        {
            List<Personaje> pjs = null;
            string completa = ruta + @"\Serializadora_Lista.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sw = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));
                    pjs = xmlSerializer.Deserialize(sw) as List<Personaje>;
                }

                return pjs;

            }
            catch (Exception e)
            {

                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
