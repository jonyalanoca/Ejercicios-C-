using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ejercicio6
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }
        public static double CalcularAreaTriangulo(double base1, double altura)
        {
            return (base1 * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return 3.14 * (Math.Pow(radio, 2));
        }
    }
}
