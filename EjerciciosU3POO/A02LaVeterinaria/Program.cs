using BibliotecaVeterinaria;

namespace A02LaVeterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cliente 1
            Cliente cliente1 = new Cliente("Matias", "Cantero", "Mitre 123", 1131317870);
            Mascota perroCliente1 = new Mascota("Perro", "Firulais", new DateTime(2021, 5, 15));
            cliente1.AgregarMascota(perroCliente1);

            // Cliente 2
            Cliente cliente2 = new Cliente("Martin", "Arana", "Belgrano 456", 1132898976);
            Mascota gatoCliente2 = new Mascota("Gato", "Garfield", new DateTime(2020, 8, 10));
            gatoCliente2.AgregarVacuna("Triple Felina");
            cliente2.AgregarMascota(gatoCliente2);

            // Cliente 3
            Cliente cliente3 = new Cliente("Enzo", "Perez", "Sarmiento 789", 1133761312);
            Mascota gatoCliente3 = new Mascota("Gato", "Felix", new DateTime(2024, 3, 17));
            Mascota perroCliente3 = new Mascota("Perro", "Lobo", new DateTime(2024, 3, 17));
            perroCliente3.AgregarVacuna("Contra la rabia");
            cliente3.AgregarMascota(gatoCliente3);
            cliente3.AgregarMascota(perroCliente3);

            // Mostrar la información de los clientes y sus mascotas
            Console.WriteLine("Información del Cliente 1:");
            Console.WriteLine(cliente1.MostrarInfo());

            Console.WriteLine("Información del Cliente 2:");
            Console.WriteLine(cliente2.MostrarInfo());

            Console.WriteLine("Información del Cliente 3:");
            Console.WriteLine(cliente3.MostrarInfo());
        }
    }
}