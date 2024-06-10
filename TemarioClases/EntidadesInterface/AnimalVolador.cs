namespace EntidadesInterface
{
    public abstract class AnimalVolador
    {
        protected string nombre;

        public AnimalVolador(string nombre)
        {
            this.nombre = nombre;
        }

        public string Volar()
        {
            return "Volando por los cielos.....";
        }
    }
}