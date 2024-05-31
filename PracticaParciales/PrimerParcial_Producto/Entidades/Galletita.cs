using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        protected static bool _deConsumo;
        protected float _peso;

        public override float CalcularCostosDeProduccion
        {
            get
            {
                return Precio * 0.33f;
            }
        }

        static Galletita()
        {
            _deConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            : base(codigoBarra, marca: marca, precio: precio)
        {
            _peso = peso;
        }

        private string MostrarGalletita()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine($"Peso: {_peso}");
            sb.AppendLine($"Consumo: {(_deConsumo ? "Si" : "No")}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarGalletita();
        }

        public override string Consumir()
        {
            return "Comestible";
        }

    }
}
