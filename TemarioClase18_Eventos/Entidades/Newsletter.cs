namespace Entidades
{
    // los objetos Newsletter son los emisores del evento
    public class Newsletter // analogia con el form: Button
    {
        // el delegado que utilizamos p/ un evento deberia devolver void // newsLetterHander por legibilidad o usar Action
        public delegate void NovedadHandler (Newsletter sender, NewsletterEventArgs eventArgs);

        // evento que va a ser lanzado (DE TIPO DELEGADO)
        public event NovedadHandler EventoNovedadEnviada; // analogia: Click

        private string tema;

        public Newsletter(string tema)
        {
            this.tema = tema;
        }
        public string Tema => tema;

        // Método que lanza el evento
        public void EnviarNovedades()
        {
            if (EventoNovedadEnviada is not null)
            {
                NewsletterEventArgs eventArgs = new NewsletterEventArgs();
                eventArgs.Contenido = "Test";

                // Invocar el evento
                EventoNovedadEnviada.Invoke(this, eventArgs);
            }
        }

    }
}