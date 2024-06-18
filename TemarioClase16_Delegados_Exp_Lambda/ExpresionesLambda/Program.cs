namespace ExpresionesLambda
{
    public class Program
    {
        public delegate int Operador(int a, int b);

        static void Main(string[] args)
        {
            // Crear instancias del delegado usando expresiones lambda
            Operador suma = (a, b) => a + b;
            Operador resta = (a, b) => a - b;
            Operador multiplicacion = (a, b) => a * b;
            Operador division = (a, b) => a / b;

            // Lista de operaciones para iterar
            List<Operador> operaciones = new List<Operador>();

            operaciones.Add(suma);
            operaciones.Add(resta);
            operaciones.Add(multiplicacion);
            operaciones.Add(division);

            int num1 = 10;
            int num2 = 2;

            foreach (var operacion in operaciones)
            {
                int resultado = operacion(num1, num2);
                Console.WriteLine($"Resultado de la operación: {resultado}");
            }
        }
    }
}