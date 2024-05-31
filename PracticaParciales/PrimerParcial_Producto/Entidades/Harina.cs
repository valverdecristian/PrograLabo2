using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        protected static bool _deConsumo;
        protected ETipoHarina _tipo;

        public override float CalcularCostosDeProduccion
        {
            get
            {
                return Precio * 0.60f;
            }
        }

        static Harina()
        {
            _deConsumo = false;
        }

        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base (codigo, precio: precio, marca: marca)
        {
            _tipo = tipo;
        }

        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"Tipo: {_tipo}");
            sb.AppendLine($"Consumo: {(_deConsumo ? "Si" : "No")}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarHarina();
        }
    }

    
}
