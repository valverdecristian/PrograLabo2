namespace TemarioClase16_Delegados_Exp_Lambda
{
    // el delegado solamente va a llamar al metodo. conoce lo necesario (que este adentro del metodo)
    public delegate void DelegadoDestinatario();
    public delegate void DelegadoDestinatarioConTiempo(int tiempo);

    public class Program
    {
        static void Main(string[] args)
        {
            Receptor r1 = new Receptor("Cristian");
            Receptor r2 = new Receptor("Lautaro");
            Receptor r3 = new Receptor("Franco");
            Receptor r4 = new Receptor("Martin");
            Receptor r5 = new Receptor("Alexis");

            // puedo guardar mas de una referencia a metodos
            DelegadoDestinatario delegadoUno = r5.RecibirNotificacion;
            delegadoUno += r4.RecibirNotificacion;
            delegadoUno += CambiarColorConsola;

            delegadoUno(); // solo con este delegado llame a otros

            // ------------------------------------------------------------------------------
            Emisor.destinatarios.Add(r1.RecibirNotificacion); // *1
            Emisor.destinatarios.Add(r2.RecibirNotificacion);

            Emisor.destinatarios.Add(Notificar); // estoy guardando una ref a un metodo estatico
            Emisor.destinatarios.Add(CambiarColorConsola);

            Emisor.destinatariosConTiempo.Add(Notificar2);

            Emisor.ProdNotificacion();

            // Thread.Sleep(2000);

            // ambas formas son validas
            DelegadoDestinatario delegadoDestinatario = new DelegadoDestinatario(r3.RecibirNotificacion); //*1
            DelegadoDestinatario delegadoDestinatario2 = r4.RecibirNotificacion;

            // para llamar a un delegado
            delegadoDestinatario.Invoke(); // mas relacionado a eventos
            delegadoDestinatario2();
        }
        // *1: ambas formas instancian un delegado

        public static void Notificar()
        {
            Console.WriteLine("Metodo1: Se envio una notificacion");
        }

        public static void Notificar2(int tiempoDeEspera)
        {
            Console.WriteLine($"Metodo2: Se envio una notificacion despues de {tiempoDeEspera}");
        }

        public static void CambiarColorConsola()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
    }

    public class Receptor
    {
        string nombre;

        public Receptor(string nombre)
        {
            this.nombre = nombre;
        }

        public void RecibirNotificacion()
        {
            Console.WriteLine($"Yo {nombre} recibi una notificacion a las {DateTime.Now}");
        }
    }

    public static class Emisor // clase que va a manejar una lista de delegados
    {
        public static Random random = new Random(); // declarado para destinatariosConTiempo

        public static List<DelegadoDestinatario> destinatarios = new List<DelegadoDestinatario>();
        public static List<DelegadoDestinatarioConTiempo> destinatariosConTiempo = new List<DelegadoDestinatarioConTiempo>();

        public static void ProdNotificacion()
        {
            destinatarios.Sort((e1,e2) => string.Compare(e1.Method.Name, e2.Method.Name));

            // el metodo where filtra
            // var filtrado = destinatarios.Where(Filtrar).ToList();

            Console.WriteLine("produciendo Notificacion");

            // se invoca al delegado utilizando un bucle o "Invoke()"
            foreach (var item in destinatarios)
            {
                // suspende el hilo actual por la cantidad de segundos especificados
                Thread.Sleep(2000);
                item(); // delegado();
            }

            foreach (var item in destinatariosConTiempo)
            {
                int tiempo = random.Next(2000, 4000);
                Thread.Sleep(tiempo);
                item(tiempo);
            }
        }

        public static bool Filtrar(DelegadoDestinatario destinatario)
        {
            return destinatario.Method.Name.StartsWith('N');
        }

        public static int Comparar(DelegadoDestinatario d1, DelegadoDestinatario d2)
        {
            // de esta forma se compara los metodos del delegado y se los ordena
            return string.Compare(d1.Method.Name, d2.Method.Name);
        }
    }
}