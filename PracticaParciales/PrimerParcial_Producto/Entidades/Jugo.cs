using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        protected static bool _deConsumo; // duda
        protected ESaborJugo _sabor;

        public override float CalcularCostosDeProduccion
        {
            get
            {
                return Precio * 0.4f;
            }
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca:marca, precio:precio)
        {
            _sabor = sabor;
        }

        static Jugo() // me dice de inicializar _deConsumo
        {
            _deConsumo = true;
        }

        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"Sabor: {_sabor}");
            sb.AppendLine($"Consumo: {(_deConsumo ? "Si":"No")}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarJugo();
        }

        public override string Consumir()
        {
            return "Bebible";
        }
    }
}
