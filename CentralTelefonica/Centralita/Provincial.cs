using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(nroOrigen: origen, duracion: duracion, nroDestino: destino)
        {
            franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo = 0;

            if(franjaHoraria == Franja.Franja_1)
            {
                costo = 0.99f;
            }
            else if(franjaHoraria == Franja.Franja_2)
            {
                costo = 1.25f;
            }
            else if(franjaHoraria == Franja.Franja_3)
            {
                costo = 0.66f;
            }

            return Duracion * costo;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: ${CalcularCosto()}");
            sb.AppendLine($"Franja Horaria: {franjaHoraria}");

            return sb.ToString();
        }

    }
}
