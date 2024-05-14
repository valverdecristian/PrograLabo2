using System.Drawing;
using System.Text;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock)
            :this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe)
            :this(nombre, stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                if(stock > 0 && importe > 0)
                {
                    return true;
                }

                return false;
            }
        }

        public float Importe
        {
            get { return  importe; }
        }

        public int Stock
        {
            get
            {
                return stock;
            }
            set // no olvidar el = 
            {
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }

        public string ObtenerInformacion()
        {
            // no olvidar este operador ternario que cambia los valores de true y false;
            string esColor = EsColor ? "SI" : "NO";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre.ToUpper()}");
            sb.AppendLine($"Stock: {stock.ToString().ToUpper()}");
            sb.AppendLine($"Es color: {esColor.ToString().ToUpper()}");
            sb.Append($"Importe: ${importe.ToString().ToUpper()}");

            return sb.ToString();

        }

        public override string ToString()
        {
            return nombre;
        }

    }
}