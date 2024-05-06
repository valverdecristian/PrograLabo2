using System.Text;

namespace HerenciaDeportiva
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre):this(nombre)
        {
            this.Dni = dni;
        }

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"DNI: {Dni}");

            return sb.ToString();
        }
    }
}