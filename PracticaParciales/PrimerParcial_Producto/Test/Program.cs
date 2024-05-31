using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estatenteUno = new Estante(4);
            Estante estanteDos = new Estante(3);
            Harina h1 = new Harina(102, 37.5f, EMarcaProducto.Favorita, ETipoHarina.CuatroCeros);
            Harina h2 = new Harina(103, 40.25f, EMarcaProducto.Favorita, ETipoHarina.Integral);
            Galletita g1 = new Galletita(113, 33.65f, EMarcaProducto.Pitusas, 250f);
            Galletita g2 = new Galletita(111, 56f, EMarcaProducto.Diversion, 500f);
            Jugo j1 = new Jugo(112, 25f, EMarcaProducto.Naranju, ESaborJugo.Pasable);
            Jugo j2 = new Jugo(333, 33f, EMarcaProducto.Swift, ESaborJugo.Asqueroso);
            Gaseosa g = new Gaseosa(333, 33f, EMarcaProducto.Swift, 2250f);

            if (!(estatenteUno + h1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante.");
            }
            if (!(estatenteUno + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante.");
            }
            if (!(estatenteUno + g2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante.");
            }
            if (!(estatenteUno + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante. g1");
            }
            if (!(estatenteUno + j1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante.");
            }
            if (!(estanteDos + h2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante.");
            }
            if (!(estanteDos + j2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(estanteDos + g))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(estanteDos + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!! g1 de nuevo");
            }

            Console.WriteLine("\n******** INFORMACIÓN DE LOS ESTANTES ********");
            Console.WriteLine("- Valor total primer estante: ${0:##.##}", estatenteUno.ValorEstanteTotal);
            Console.WriteLine("- Valor del primer estante sólo de Galletitas: ${0:##.##}", estatenteUno.GetValorEstante(ETipoProducto.Galletita));
            Console.WriteLine("\n=== Contenido primer estante ===\n{0}",
            
            Estante.MostrarEstante(estatenteUno));
            Console.WriteLine("== Primer estante ordenado ===");
            estatenteUno.OrdenarProductos();
            Console.WriteLine(Estante.MostrarEstante(estatenteUno));

            estatenteUno = estatenteUno - ETipoProducto.Galletita;
            Console.WriteLine("=== Primer estante sin galletitas ===\n{0}",
            Estante.MostrarEstante(estatenteUno));

            Console.WriteLine("=== Contenido segundo estante ===\n{0}",
            Estante.MostrarEstante(estanteDos));
            estanteDos -= ETipoProducto.Todos;
            Console.WriteLine("=== Contenido segundo estante ===\n{0}",
            Estante.MostrarEstante(estanteDos));

            string rutaApplicationData =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaProductos.txt";
            string rutaArchivo = Path.Combine(rutaApplicationData, nombreArchivo);

            Console.WriteLine("Guardando información del primer estante en un archivo");
            Estante.GuardarEstante(estatenteUno, rutaArchivo);
            Console.ReadLine();
            const string nombreXML = "listaProductos.xml";
            rutaArchivo = Path.Combine(rutaApplicationData, nombreXML);
            Console.WriteLine("Serializando información del primer estante");
            Estante.SerializarEstante(estatenteUno, rutaArchivo);
            Console.WriteLine("Serializando información del primer estante");
            Estante.DeserializarEstante(rutaArchivo);
        }
    }
}