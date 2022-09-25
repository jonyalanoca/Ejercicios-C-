using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2.ejercicio7
{
    public static class LongitudHipotenusa
    {
       
        public static double CalcularLongitud(double base1, double altura)
        {
            return Math.Sqrt(Math.Pow(base1,2) +Math.Pow(altura,2));
        }
    }
}
