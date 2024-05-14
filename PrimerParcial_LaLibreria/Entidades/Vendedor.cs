using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        string nombre;
        List<Publicacion> ventas;

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static string ObtenerInformeDeVentas(Vendedor vendedor)
            // no olvidar el detalle de mostrar la info del vendedor del parametro
        {
            float gananciaTotal = 0;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(vendedor.nombre.ToUpper());
            sb.AppendLine("----------------------");

            foreach (Publicacion venta in vendedor.ventas)
            {
                sb.AppendLine($"PUBLICACION: {venta.ObtenerInformacion()}");
                gananciaTotal += venta.Importe;
            }
            sb.AppendLine("----------------------");
            sb.AppendLine($"Ganancia total: {gananciaTotal}");


            return sb.ToString();
        }

        // mirar mas este metodo que agrega siempre y cuando haya stock suficiente p/ realizar
        // la venta, se agrega la info de esa publicacion a la lista de ventas y se descuenta
        // stock de la publicacion.
        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if ( publicacion != null )
            {
                if(publicacion.HayStock)
                {
                    vendedor.ventas.Add(publicacion);
                    publicacion.Stock--;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
