using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtension
    {
        public static int ContarVocales(string texto)
        {
            if(string.IsNullOrEmpty(texto))
            {
                return 0;
            }

            texto = texto.ToLower();
            char[] vocales = {'a', 'e', 'i', 'o', 'u' };
            int contador = 0;

            foreach (char caracter in texto)
            {
                if(vocales.Contains(caracter))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarPalabras(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }

            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
