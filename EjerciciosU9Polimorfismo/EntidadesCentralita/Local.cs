using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada { get => costo; }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion: duracion, nroDestino: destino, nroOrigen: origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
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
