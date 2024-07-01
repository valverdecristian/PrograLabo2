namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    /* CONCURRENCIA:
     * Hablamos de concurrencia cuando se ejecuta mas de una tarea al mismo tiempo.
     * 
     * Uso de concurrencia en aplicaciones:
     * Los usuarios finales puedan interactuar con la intrfaz de manera no-bloqueante
     * Un servidor pueda atender varias peticiones
     * 
     * PROGRAMACION MULTI-HILO:
     * Trabajar multiples cosas en simultaneo y en armonia
     * Un hilo (o subproceso) es la unidad basica a la que un sistema operativo asigna tiempo
     * de procesamiento. Son los encargados de ejecutar nuestro codigo sentencia a sentencia.
     * 
     * PROCESO:
     * Un proceso es un programa en ejecucion que tiene asignados recursos tales como memoria
     * e hilos.
     * 
     * Por defecto, cada proceso tiene un unico hilo.
     * 
     * La PROGRAMACION MULTI-HILO permite que un proceso se ejecute sobre multiples hilos y
     * cada uno de esos hilos este realizando una tarea distinta en paralelo.
     * La programacion en paralelo es un sub-tipo de programacion multi-hilo.
     * 
     * Ciclo de vida de un hilo
     * Se llama hilo principal al primer hilo sobre el que se empezo a ejecutar la app
     * A partir de un hilo se pueden abrir nuevos hilos secundarios.
     * Un hilo secundario va a tener su propia PILA DE EJECUCION
     * El proceso existira mientras al menos uno de sus hilos de ejecucion siga activo
     * El proceso no existe mas cuando TODOS los hilos de ejecucion finalizan.
     */
}