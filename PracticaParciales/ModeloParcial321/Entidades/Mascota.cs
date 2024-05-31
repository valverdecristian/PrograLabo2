using System.Text;

namespace Entidades
{
    public abstract class Mascota
    {
        string _nombre;
        string _raza;

        public Mascota(string nombre, string raza) // protected?
        {
            _nombre = nombre;
            _raza = raza;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Raza
        {
            get { return _raza; }
        }

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Raza: {Raza}");

            return sb.ToString();
        }

        protected abstract string Ficha();
    }
}