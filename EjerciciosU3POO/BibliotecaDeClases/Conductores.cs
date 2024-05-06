using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Conductores
    {
        private string? nombre;
        private int[] kilometros;
        private int contadorDias;

        public Conductores(string? nombre)
        {
            this.nombre = nombre;
            kilometros = new int[7];
            contadorDias = 0;
        }

        public void AgregarKilometros(int kilometros)
        {
            if (this.kilometros.Length < 7)
            {
                this.kilometros[contadorDias] = kilometros;
                contadorDias++;
            }
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            for (int i = 0; i < kilometros.Length; i++)
            {
                sb.AppendLine($"Kilometros recorridos: {kilometros[i]}");
            }

            return sb.ToString();
        }
    }
}
