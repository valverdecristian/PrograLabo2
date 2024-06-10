using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesGenerics
{
    public class Pila<T>
    {
        private List<T> elementos = new List<T>();

        public void Push(T elemento)
        {
            elementos.Add(elemento);
        }

        public void Mostrar()
        {
            foreach (T elemento in elementos)
            {
                Console.WriteLine(elemento.ToString());
            }
        }

        public T Pop()
        {
            if (elementos.Count == 0)
            {
                throw new Exception("No tengo elementos en mi pila");
            }

            int ultimoIndex = elementos.Count - 1;
            T aux = elementos[ultimoIndex];
            elementos.RemoveAt(ultimoIndex);

            return aux;
        }

        public static void EjecutarToString(T elemento)
        {
            Console.WriteLine(elemento.ToString());
        }
    }
}
