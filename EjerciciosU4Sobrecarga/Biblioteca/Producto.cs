using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {   // 1
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio) // 2
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca () // 3
        {
            return marca;
        }

        public float GetPrecio ()
        {
            return precio;
        }

        public static string MostrarProducto(Producto producto) // 5
        {
            if(producto is not null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Marca: {producto.GetMarca()}");
                sb.AppendLine($"Precio: {producto.GetPrecio()}");
                sb.AppendLine($"Codigo: {(string)producto}");

                return sb.ToString();

            }

            return "producto nulo";
        }

        public static explicit operator string(Producto producto) // 6i y 4
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2) // 6ii
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public static bool operator ==(Producto producto, string marca) // 6iii
        {
            if(producto.marca == marca)
            {
                return true;
            }
            return producto.marca == marca;
        }

        public static bool operator !=(Producto producto1, string marca)
        {
            return !(producto1 == marca);
        }

    }
}
