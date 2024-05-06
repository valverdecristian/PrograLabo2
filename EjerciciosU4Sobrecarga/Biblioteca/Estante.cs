using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante) : this(capacidad) // 2
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante estante) // 4
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicacion: {estante.ubicacionEstante}");
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (!Object.ReferenceEquals(estante.productos[i], null))
                {
                    sb.AppendLine(Producto.MostrarProducto(estante.productos[i]));
                    sb.AppendLine("----------------------");

                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante estante, Producto producto) // 5i
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    return true;

                }
            }

            return false;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            if (estante != producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i] is null)
                    {
                        estante.productos[i] = producto;
                        return true;
                    }
                }
            }

            return false;
        }

        public static Estante operator -(Estante estante, Producto producto)
        {
            
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if(estante == producto)
                {
                    Console.WriteLine($"se elimino {producto}");
                    estante.productos[i] = null; // con esto elimino el producto al asignarle null
                    break;
                }
            }
            return estante;
        }


    }
}
