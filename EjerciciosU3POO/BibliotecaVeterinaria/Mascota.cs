using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVeterinaria
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string[] historialVacunacion;
        private int contadorVacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            historialVacunacion = new string[4];
            contadorVacunas = 0;
        }

        public void AgregarVacuna(string nombreVacuna)
        {
            if (contadorVacunas < 4)
            {
                historialVacunacion[contadorVacunas] = nombreVacuna;
                contadorVacunas++;
            }
            else
            {
                Console.WriteLine("No se puede agregar más vacunas. Historial completo.");
            }
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Especie: {especie}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento}");
            sb.AppendLine("Historial de Vacunación:");
            for (int i = 0; i < contadorVacunas; i++)
            {
                sb.AppendLine(historialVacunacion[i]);
            }

            return sb.ToString();
        }
    }
}
