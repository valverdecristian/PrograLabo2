using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

// Clase Bombero:
// Implementará la interfaz IArchivos tantas veces como muestra el diagrama. Esto requerirá implementar la interfaz de forma implícita y de forma explícita.
// Para Bombero: serializará y deserializará el objeto en formato XML. Almacenarlo en un archivo Bombero.xml en el escritorio.
// Para string: guardará y leerá de la base de datos el mensaje recibido como parámetro. Al leer concatenar todos las entradas del log en un solo string.
// El método AtenderSalida realizará lo siguiente:
// Agregará una nueva salida a la lista del bombero.
// Suspenderá el hilo entre 2 y 4 segundos.
// Finalizará la salida.
// Registrará la salida (horario de inicio, horario de fin y duración total) en la tabla log de la base de datos.
// Avisará mediante el evento MarcarFin que se terminó la salida. Utilizar el parámetro bomberoIndex para informar al formulario cuál bombero fue.

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);

    // implementamos IArchivo de dos formas
    public class Bombero: IArchivo<Bombero>, IArchivo<string>
    {
        public event FinDeSalida MarcarFin;

        private string nombre;
        private List<Salida> salidas;
        private static string rutaArchivo;
        private static Random random;

        // el constructor sin parametros esta obligado para la serializacion en XML
        public Bombero()
        {
            salidas = new List<Salida>();
        }

        public Bombero(string nombre) :this()
        {
            this.nombre = nombre;
        }

        // constructor statico que me inicialice la ruta del archivo
        static Bombero()
        {
            rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.xml");
            random = new Random();
        }

        // recordar que para serializar en XML necesitamos propiedades publicas, si bien no estaba en el diagrama
        // hay que deducirlo y por lo tanto declararlo en el codigo, para su posterior uso
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salida> Salidas { get => salidas; set => salidas = value; }

        public void Guardar(Bombero info)
        {
            using StreamWriter streamWriter = new StreamWriter(rutaArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
            xmlSerializer.Serialize(streamWriter, info);
        }

        public Bombero Leer()
        {
            using StreamReader streamReader = new StreamReader(rutaArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
            return (Bombero)xmlSerializer.Deserialize(streamReader);
        }

        void IArchivo<string>.Guardar(string info)
        {
            LogDAO logDAO = new LogDAO();
            logDAO.InsertarLog(info);
        }

        string IArchivo<string>.Leer()
        {
            LogDAO logDAO = new LogDAO();
            return logDAO.LeerLog();
        }

        public void AtenderSalida(int bomberoIndex)
        {
            // 1. agregar una nueva salida a la lista
            Salida salida = new Salida();
            salidas.Add(salida);

            // 2. Suspender el hilo entre 2 y 4 segundos (usar random)
            Thread.Sleep(random.Next(2000, 4000));

            // 3. Finalizar salida
            salida.FinalizarSalida();

            // 4. Registrar la salida en la tabla log de la DB (hacerlo con StringBuilder)
            string log = $"Salida finalizada. Inicio: {salida.FechaInicio.ToLongTimeString()}. " +
                $"Fin: {salida.FechaFin.ToLongTimeString()}. " + $"Duracion: {salida.TiempoTotal} segundos";

            // implementamos la interfaz explicitia
            ((IArchivo<string>)this).Guardar(log); // se guarda en la base de datos

            // aviso mediante un evento
            MarcarFin.Invoke(bomberoIndex);
        }
    }
}
