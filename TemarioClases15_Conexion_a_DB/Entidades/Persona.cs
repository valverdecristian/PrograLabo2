namespace Entidades
{
    public class Persona
    {
        // no necesariamente tiene que coincidir con la tabla
        // se trae lo que se necesita
        // si la columna no acepta nulos hay que setearlo
        string nombre;
        int id;

        public Persona(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public Persona(string nombre):this(nombre,0)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}