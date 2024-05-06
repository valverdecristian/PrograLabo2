using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public static class Calculadora
    {
        public static int Calcular(int primerOperando, int segundoOperando, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return primerOperando + segundoOperando;
                case "-":
                    return primerOperando - segundoOperando;
                case "*":
                    return primerOperando * segundoOperando;
                case "/":
                    if(Validar(segundoOperando))
                    {
                        return primerOperando / segundoOperando;
                    }
                    else
                    {
                        return -1;
                    }
                default:
                    return -1;
            }
        }

        private static bool Validar(int segundoOperando)
        {
            return segundoOperando != 0 ? true : false;
        }

        public static int Sumar(int numero, int otroNumero)
        {
            return numero + otroNumero;
        }
    }
}
