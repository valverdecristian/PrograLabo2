using System.Text;

namespace Centralita
{
    public enum TipoLlamada
    {
        Local, Provincial, Todas
    }

    public class Llamada
    {
        protected float duracion;
        protected string? nroDestino;
        protected string? nroOrigen;

        public Llamada(float duracion, string? nroDestino, string? nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return duracion; }
        }
        public string NroDestino
        {
            get { return nroDestino; }
        }
        public string NroOrigen
        {
            get { return nroOrigen; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Numero de Destino: {nroDestino}");
            sb.AppendLine($"Numero de Origen: {nroOrigen}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1,  Llamada llamada2)
        {
            if(llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            else if(llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else { return 0; }
        }


    }
}