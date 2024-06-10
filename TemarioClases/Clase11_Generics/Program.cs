﻿using EntidadesGenerics;

namespace Clase11_Generics
{
    // ejemplo claro: las listas genericas
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pila<int> numeros = new Pila<int>();

                Pila<string> palabras = new Pila<string>();

                Pila<Persona> personas = new Pila<Persona>();

                Persona p1 = new Persona("Lautaro");
                Persona p2 = new Persona("Gustavo");
                Persona p3 = new Persona("Lucas");



                Console.WriteLine("INT ----------------------------------------------------");

                numeros.Push(1);
                numeros.Push(9);
                numeros.Push(7);
                numeros.Mostrar();
                int auxInt = numeros.Pop();
                Console.WriteLine($"Valor aux: {auxInt}");
                numeros.Mostrar();


                Console.WriteLine("STRING --------------------------------------------------");

                palabras.Push("Hello");
                palabras.Push("There");
                palabras.Push("General Kenobi");
                palabras.Mostrar();
                string auxString = palabras.Pop();
                Console.WriteLine($"Valor aux: {auxString}");
                palabras.Mostrar();

                Console.WriteLine("PERSONA --------------------------------------------------");
                personas.Push(p1);
                personas.Push(p2);
                personas.Push(p3);
                personas.Mostrar();
                Persona auxPersona = personas.Pop();
                Console.WriteLine($"Valor aux: {auxPersona.ToString()}");
                personas.Mostrar();

                //Pila<int>.EjecutarToString(3);
                //Pila<string>.EjecutarToString("Hello there");
                //Pila<Persona>.EjecutarToString(p1);




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}