namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

/* Teoria:
 * Los eventos son "mensajes" (notificaciones) que emiten clases (eventos estaticos) u objetos
 * (eventos de instancia) cuando ocurre algo en particular dentro del objeto. Ese algo puede ser
 * la accion del usuario, cambio de estado de un objeto.
 * 
 * El emisor/remitente (o sender) es el objeto que genera el evento. Envia una notificacion de que
 * ha ocurrido un evento. No sabe que objeto o metodo recibira (manejara) los eventos que genera.
 * El receptor recibe esa notificacion y determina que hacer.
 * 
 * Eventos y delegados:
 * El delegado es un intermediario entre el evento y el codigo que lo maneja.
 * Por convencion el identificador del delegado termina con la palabra "Handler" y el evento
 * empieza con la palabra "On".
 * 
 * Declaracion de un evento:
 * Palabra reservada "event"
 * El tipo del evento debe ser un tipo de delegado
 * El identificador del evento debe ser un verbo o frase verbal.
 * Notacion UpperCamelCase
 * 
 * Suscripcion a un evento:
 * El codigo que maneja el evento se lo conoce como "metodo manejador" (del evento)
 * Para asociar un manejador (de la clase FormPrincipal: Form) al evento (segundoCambiado) se debe
 * usar el operador += (o el -= para desasociar)
 * La firma del metodo manejador debe coincidir con la firma del delegado.
 * Todos los eventos son delegados, pero no todos los delegados son eventos.
 * 
 * Generar/Lanzar Eventos:
 * Se debe validar que el evento no sea nulo
 * Usar el .Invoke
 * Si no es nulo quiere decir que tiene suscriptores ese evento (evitar NullReferenceException)
 * 
 * EvenArgs:
 * Es la clase base para todos los datos de eventos.
 * 
 */