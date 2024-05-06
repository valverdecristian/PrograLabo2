using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada { get => costo; set => costo = value; }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion:duracion,nroDestino:destino, nroOrigen:origen)
        {
            CostoLlamada = costo;
        }

        private float CalcularCosto()
        {
            return CostoLlamada * duracion;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {CalcularCosto()}");

            return sb.ToString();
        }
    }
}
