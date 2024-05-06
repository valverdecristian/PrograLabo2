namespace C03_Maquina_exprimidora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();

            maquinaExpendedora.Add(1, "Papas");
            maquinaExpendedora.Add(2, "Barrita de cereal");
            maquinaExpendedora.Add(3, "Alfajor");
            maquinaExpendedora.Add(4, "Pitusas Frutilla");
            maquinaExpendedora.Add(5, "Chocolate Milka");
            maquinaExpendedora.Add(6, "7up");
            maquinaExpendedora.Add(7, "Fanta");
            maquinaExpendedora.Add(8, "Coca Cola");
            maquinaExpendedora.Add(9, "Agua saborizada");
            maquinaExpendedora.Add(10, "Agua");

            string inputRespuesta = "";

            do
            {
                foreach (KeyValuePair<int, string> item in maquinaExpendedora)
                {
                    Console.WriteLine($"Codigo: {item.Key} - {item.Value}");
                }

                Console.WriteLine("\nElila un numero del producto que desea comprar:");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int entradaNumero) && entradaNumero <= maquinaExpendedora.Count)
                {
                    foreach (var item in maquinaExpendedora)
                    {
                        if (item.Key == entradaNumero)
                        {
                            Console.WriteLine($"Eligio: {item.Value}");
                            maquinaExpendedora.Remove(item.Key);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Numero fuera de rango o fuera de la lista de productos disponibles");
                }

                Console.WriteLine("\nSi desea salir presionar S, sino cualquier tecla para continuar");
                inputRespuesta = Console.ReadLine();

            } while (inputRespuesta.ToLower() != "S".ToLower());

            Console.WriteLine($"\nGracias por su compra");
        }
    }
}