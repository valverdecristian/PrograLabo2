using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double pi = Math.PI;
            return pi * Math.Pow(radio, 2);
        }
    }
}
