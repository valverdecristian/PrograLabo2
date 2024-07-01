namespace Hilos_Ejemplo1
{
    internal class Program
    {
        private static DateTime time;
        private static Random random;

        static void Main(string[] args)
        {
            random = new Random();
            time = DateTime.Now;
            EjecutarSincronico();
        }

        public static void EjecutarEnParalelo()
        {
            // la clase Task viene de tarea (antes se usaba Thread)
            Task hiloParalelo = 
        }

        public static void EjecutarSincronico()
        {
            // Queue de tipo delegado Action
            Queue<Action> tareas = new Queue<Action>();

            // () => metodo : es una expresion lambda que no recibe parametros y no retorna nada
            tareas.Enqueue(() => EjecutarTarea("SINC-A"));
            tareas.Enqueue(() => EjecutarTarea("SINC-B"));
            tareas.Enqueue(() => EjecutarTarea("SINC-C"));
            tareas.Enqueue(() => EjecutarTarea("SINC-D"));
            tareas.Enqueue(() => EjecutarTarea("SINC-E"));
            tareas.Enqueue(() => EjecutarTarea("SINC-F"));

            foreach (Action tarea in tareas)
            {
                tarea();
            }
        }

        public static void EjecutarTarea(string codigo)
        {
            int tiempo = random.Next(1000, 5000);
            Thread.Sleep(tiempo);
            Console.WriteLine($"{DateTime.Now:T} - Tarea {codigo} completada en {tiempo} ms.");
        }
    }
}