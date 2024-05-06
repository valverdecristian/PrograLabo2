namespace Ejercicio7Pitagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            //Crear una aplicación de consola que pida al usuario ingresar la base y
            //la altura de un triángulo en centímetros.
            //El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
            //Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
            //Mostrar el resultado en la consola.
            #endregion

            Console.WriteLine("Ingresar la base del triangulo");
            string inputBase = Console.ReadLine();
            Console.WriteLine("Ingresar la altura del triangulo");
            string inputAltura = Console.ReadLine();

            if (double.TryParse(inputBase, out double catetoBase) && double.TryParse(inputAltura, out double catetoAltura))
            {
                double suma = Math.Pow(catetoBase, 2) + Math.Pow(catetoAltura, 2);
                double hipotenusa = Math.Sqrt(suma);

                Console.WriteLine($"La hipotenusa del triangulo es: {hipotenusa}");
            }
            else
            {
                Console.WriteLine("NO SE PUEDO REALIZAR EL CALCULO");
            }
        }
    }
}