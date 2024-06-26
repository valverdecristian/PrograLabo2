﻿namespace I01Numeros_Locos
{
    #region Consigna:
    /* Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos)
        distintos de cero de forma aleatoria utilizando la clase Random.
    
        Mostrar el vector tal como fue ingresado.
        Luego mostrar los positivos ordenados en forma decreciente.
        Por último, mostrar los negativos ordenados en forma creciente.
     */

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom = new Random();
            int cargarNumeros = 20;
            List<int> lista = new List<int>();
            List<int> listaPositivos = new List<int>();
            List<int> listaNegativos = new List<int>();

            for (int i = 0; i < cargarNumeros; i++)
            {
                lista.Add(numeroRandom.Next(-100,100));
            }
            
            Console.WriteLine("Numeros ordenados segun vector:");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            // separo en dos listas los negativos y positivos:
            foreach(var item in lista)
            {
                if (item >  0)
                {
                    listaPositivos.Add(item);
                }
                else
                {
                    listaNegativos.Add(item);
                }
            }

            // ordenar los numeros positivos unicamente
            Console.WriteLine("\nNumeros positivos ordenados en forma decreciente");
            listaPositivos.Sort();
            listaPositivos.Reverse();

            foreach (var item in listaPositivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNumeros negativos ordenados en forma creciente");
            listaNegativos.Sort();

            foreach (var item in listaNegativos)
            {
                Console.WriteLine(item);
            }

        }
    }
}