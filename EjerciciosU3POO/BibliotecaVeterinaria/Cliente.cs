using System.Text;

namespace BibliotecaVeterinaria
{
    public class Cliente
    {
        private string? nombre;
        private string? apellido;
        private string? domicilio;
        private int telefono;
        private Mascota[] mascotas;
        private int contadorMascotas;

        public Cliente(string? nombre, string? apellido, string? domicilio, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            mascotas = new Mascota[4];
        }

        public void AgregarMascota(Mascota nuevaMascota)
        {
            if(contadorMascotas < mascotas.Length)
            {
                mascotas[contadorMascotas] = nuevaMascota;
                contadorMascotas++;
            }
            else
            {
                Console.WriteLine("No se puede agregar más mascotas");
            }
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Apellido y Nombre: {apellido} {nombre}");
            sb.AppendLine($"Domicilio: {domicilio}");
            sb.AppendLine($"Telefono: {telefono}");
            sb.AppendLine("Mascotas:");
            for (int i = 0; i < contadorMascotas; i++)
            {
                sb.AppendLine($"{mascotas[i].MostrarInfo()}");
            }

            return sb.ToString();
        }
    }
}