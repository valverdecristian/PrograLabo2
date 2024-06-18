namespace DelegadoGenerico
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 100, -281, -48, 10, 17, -24, 98, -45 };

            string numeros = string.Empty;
            foreach (int numero in lista)
            {
                numeros += $"{numero} | ";
            }

            Console.WriteLine($"Numeros antes de filtrar {numeros}");

            lista = lista.Filtrar(n => n<0);
            numeros = string.Empty;
            foreach (var numero in lista)
            {
                numeros += $"{numero} | ";
            }
            Console.WriteLine($"Numeros negativos {numeros}");

            lista = lista.Filtrar(n => n%2==0);
            numeros = string.Empty;
            foreach (var numero in lista)
            {
                numeros += $"{numero} * ";
            }
            Console.WriteLine($"Numeros pares {numeros}");
        }

        public static bool FiltrarNumerosPares(int numero) // cambiado a expresion lambda
        {
            return numero % 2 == 0;
        }

        public static bool FiltrarNumerosNegativos(int numero) // cambiado a expresion lambda
        {
            return numero < 0;
        }
    }
}