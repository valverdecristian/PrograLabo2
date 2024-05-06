using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            if (numeroEntero < 0)
            {
                throw new ArgumentException("El número entero debe ser positivo.");
            }

            string binario = string.Empty;

            while (numeroEntero > 0)
            {
                int residuo = numeroEntero % 2;
                binario = residuo + binario;
                numeroEntero /= 2;
            }

            return binario == string.Empty ? "0" : binario;
        }

        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            if (!EsBinarioValido(numeroBinario))
            {
                throw new ArgumentException("El número binario no es válido.");
            }

            int decimalResult = 0;
            int exp = 0;

            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                if (numeroBinario[i] == '1')
                {
                    decimalResult += (int)Math.Pow(2, exp);
                }
                exp++;
            }

            return decimalResult;
        }

        private static bool EsBinarioValido(string numeroBinario)
        {
            foreach (char digito in numeroBinario)
            {
                if (digito != '0' && digito != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
