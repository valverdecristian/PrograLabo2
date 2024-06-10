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
                //Archivo.Escribir();
                //ArchivoDos.Escribir();
                //Console.WriteLine(ArchivoDos.Leer());

                Personaje personaje = new Personaje("Cristian", 10);
                Personaje personaje2 = new Personaje("Jorge", 8);
                Personaje personaje3 = new Personaje("Valverde", 6);

                List<Personaje> personajeList = new List<Personaje>();

                personajeList.Add(personaje);
                personajeList.Add(personaje2);
                personajeList.Add(personaje3);

                // Serializacion.EscribirLista(personajeList);

                // Console.WriteLine(Serializacion.Leer().ToString());

                //List<Personaje> personajes = Serializacion.LeerLista();

                //foreach (var item in personajes)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                Mascota mascota = new Mascota("Moro", "boxer", 3, true, true);

                // SerializadoraJson.Escribir(mascota);

                Console.WriteLine(SerializadoraJson.Leer().ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    /* Serializar es sacarle una foto al estado de un objeto
     * y se lo serealiza a un archivo
     * para recuperar la informacion de ese objeto serializado
     * 
     * Serializamos para poder comunicarnos entre aplicaciones [c# y java, por ejemplo]
     * 
     * La serializcion se utiliza hoy en dia mas que nada para archivos de configuracion
     */
}