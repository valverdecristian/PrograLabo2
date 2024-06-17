using Entidades;

namespace Clase15_ConexionADB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // List<Persona> personas = PersonaAccesoDatos.Leer();


                //foreach (Persona persona in personas)
                //{
                //    Console.WriteLine(persona.ToString());
                //}

                #region Inyeccion
                //List<Persona> personas = PersonaAccesoDatos.LeerInyeccion("1 OR 1=1");
                //foreach (Persona p in personas)
                //{
                //    Console.WriteLine(p.ToString());
                //}
                #endregion

                //Persona personaAux = new Persona("Marcos");
                // PersonaAccesoDatos.Guardar(personaAux.Nombre);

                PersonaAccesoDatos.Eliminar(8);

                // PersonaAccesoDatos.Modificar("Joe", 1);

                //Persona persona = PersonaAccesoDatos.LeerParametrizado(1);
                //Console.WriteLine(persona);

                // guardar parametrizado
                //Persona personaAux = new Persona("Bob");
                //PersonaAccesoDatos.GuardarParametrizado(personaAux.Nombre);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}