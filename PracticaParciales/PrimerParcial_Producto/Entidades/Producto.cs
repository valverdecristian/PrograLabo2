using System.Text;

namespace Entidades
{
    public abstract class Producto
    {
        protected int _codigoDeBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public Producto(int codigoDeBarra, EMarcaProducto marca, float precio)
        {
            _codigoDeBarra = codigoDeBarra;
            _marca = marca;
            _precio = precio;
        }

        public EMarcaProducto Marca { get { return _marca; } }

        public float Precio { get { return _precio; } }

        public int CodigoDeBarras { get { return _codigoDeBarra; } }

        public abstract float CalcularCostosDeProduccion
        {
            get;
        }

        static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {p.Marca}");
            sb.AppendLine($"Precio: {p.Precio}");
            sb.AppendLine($"Codigo de barras: {p.CodigoDeBarras}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarProducto(this);
        }

        public static bool operator ==( Producto p1, Producto p2 )
        {
            return p1.GetType() == p2.GetType() && p1.Marca == p2.Marca && p1.CodigoDeBarras == p2.CodigoDeBarras;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, EMarcaProducto marca)
        {
            return p1.Marca == marca;
        }

        public static bool operator !=(Producto p1, EMarcaProducto marca)
        {
            return !(p1 == marca);
        }

        public static explicit operator int(Producto producto)
        {
            return producto._codigoDeBarra;
        }

        public static implicit operator string(Producto producto)
        {
            return MostrarProducto(producto);
        }

        public override bool Equals(object? obj)
        {
            return obj is Producto p && p == this;
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }
    }
}