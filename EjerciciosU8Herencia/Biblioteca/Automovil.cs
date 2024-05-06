using System.Text;

namespace Biblioteca
{
    public class Automovil : VeiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public new string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarInfo());
            sb.AppendLine($"Cantidad de marchas: {cantidadMarchas}");
            sb.AppendLine($"Cantidad de pasajeros: {cantidadPasajeros}");

            return sb.ToString();
        }
    }
}