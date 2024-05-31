using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        protected static bool _deConsumo;
        protected float _litros;

        public override float CalcularCostosDeProduccion
        {
            get
            {
                return Precio * 0.42f;
            }
        }

        static Gaseosa()
        {
            _deConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca: marca, precio: precio)
        {
            _litros = litros;
        }

        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"Litros: {_litros}");
            sb.AppendLine($"Consumo: {(_deConsumo ? "Si" : "No")}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarGaseosa();
        }

        public override string Consumir()
        {
            return "Bebible";
        }
    }
}
