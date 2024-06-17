using System.Text;

namespace EntidadesCentralita
{

    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get; }

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

        public Llamada(float duracion, string? nroDestino, string? nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Numero de Destino: {nroDestino}");
            sb.AppendLine($"Numero de Origen: {nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            else if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else { return 0; }
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


    }
}