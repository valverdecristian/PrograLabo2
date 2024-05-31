namespace EjemploParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 5;
            Stack<double> data = new Stack<double>();
            int i;

            for (i = max; i > 0; i--)
            {
                data.Push(i);
            }

            // hasta aca seria: 5-4-3-2-1

            for (i = 0; i < max; i++)
            {
                Console.Write(String.Format("{0}-", data.Pop()));
            }
            // El 2do for no modifica en nada a la pila.

            // salida: 1-2-3-4-5, porque el Pop ELIMINA Y DEVUELVE EL ULTIMO ELEMENTO AGREGADO
        }
    }
}