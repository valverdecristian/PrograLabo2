using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2


            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/

            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            // Punto 2
            Comparar(primerTexto, segundoTexto, (tx1, tx2) => tx1.Length - tx2.Length);

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            // Punto 3
            Comparar(primerTexto, segundoTexto, (tx1, tx2) => tx1.Split(' ').Length - tx2.Split(' ').Length);

            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            // Punto 4
            Comparar(primerTexto, segundoTexto, (tx1, tx2) => ContarVocales(tx1) - ContarVocales(tx2));

            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            // Punto 5
            Comparar(primerTexto, segundoTexto, (tx1, tx2) => ContarSignosPuntuacion(tx1) - ContarSignosPuntuacion(tx2));
        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }

        static void Comparar(string primerTexto, string segundoTexto, Func<string, string, int> criterio)
        {
            if(criterio(primerTexto, segundoTexto) > 0)
            {
                Console.WriteLine("El primer texto es mas largo que el segundo");
            }
            else if(criterio(primerTexto, segundoTexto) < 0)
            {
                Console.WriteLine("El primer texto es mas corto que el segundo");
            }
            else
            {
                Console.WriteLine("El primer texto es igual que el segundo");
            }
        }
    }
}
