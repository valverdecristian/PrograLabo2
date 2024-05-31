using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal
        {
            get
            {
                return GetValorEstante(ETipoProducto.Todos);
            }
        }

        private Estante()
        {
            _productos = new List<Producto>();
        }

        public Estante(sbyte capacidad):this()
        {
            _capacidad = capacidad;
        }

        public Estante(sbyte capacidad, List<Producto> productos):this(capacidad) 
        {
            _productos = productos;
        }



        public List<Producto> GetProductos()
        {
            return _productos;
        }

        public float GetValorEstante(ETipoProducto tipo)
        {
            float total = 0;
            foreach (Producto producto in _productos)
            {
                if (tipo == ETipoProducto.Todos || producto.GetType().Name == tipo.ToString())
                {
                    total += producto.Precio;
                }
            }
            return total;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad: {e._capacidad}");
            sb.AppendLine("Lista de productos:");
            foreach (Producto producto in e._productos)
            {
                sb.AppendLine(producto.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            return e._productos.Contains(p);
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e._productos.Count < e._capacidad && !(e == p))
            {
                e._productos.Add(p);
                return true;
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                e._productos.Remove(p);
            }
            return e;
        }

        public static Estante operator -(Estante e, ETipoProducto tipo)
        {
            e._productos.RemoveAll(p => p.GetType().Name == tipo.ToString());
            return e;
        }

        public static void GuardarEstante(Estante e, string filePath)
        {
            File.WriteAllText(filePath, MostrarEstante(e));
        }

        public static void SerializarEstante(Estante e, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Estante));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, e);
            }
        }

        public static Estante DeserializarEstante(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Estante));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (Estante)serializer.Deserialize(reader);
            }
        }

        public void OrdenarProductos()
        {
            _productos.Sort((p1, p2) => p1.CodigoDeBarras.CompareTo(p2.CodigoDeBarras));
        }
    }
}
