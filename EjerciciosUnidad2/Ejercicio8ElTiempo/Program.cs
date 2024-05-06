using System.Security.Cryptography;
using System;

namespace Ejercicio8ElTiempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Consigna
            //Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha
            //hasta la fecha actual.Tener en cuenta los años bisiestos.

            //Pedir por consola la fecha de nacimiento de una persona(día, mes y año) y calculr el número
            //de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

            //Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
            #endregion

            Console.WriteLine("Ingresar el dia");
            string inputDia = Console.ReadLine();
            Console.WriteLine("Ingresar el numero del mes");
            string inputMes = Console.ReadLine();
            Console.WriteLine("Ingresar el año");
            string inputYear = Console.ReadLine();

            bool validarDia = int.TryParse(inputDia, out int dia);
            bool validarMes = int.TryParse(inputMes, out int mes);
            bool validarYear = int.TryParse(inputYear, out int year);

            if (validarDia && validarMes && validarYear)
            {
                DateTime fechaNacimiento = new DateTime(year, mes, dia);
                DateTime fechaActual = DateTime.Now;

                int diasVividos = CalcularDiasVividos(fechaNacimiento, fechaActual);

                Console.WriteLine($"Número de días vividos: {diasVividos} días");

            }
            else
            {
                Console.WriteLine("No se pudo realizar la operacion");
            }


        }

        static int CalcularDiasVividos(DateTime fechaNacimiento, DateTime fechaActual)
        {
            TimeSpan diferencia = fechaActual - fechaNacimiento;
            int diasVividos = diferencia.Days;

            return diasVividos;
        }
    }
}