using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class VeiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VeiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        public Colores Color { get => color; set => color = value; }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {cantidadRuedas}");
            sb.AppendLine($"Cantidad de puertas: {cantidadPuertas}");
            sb.AppendLine($"Color: {color}");

            return sb.ToString();
        }
    }
}
