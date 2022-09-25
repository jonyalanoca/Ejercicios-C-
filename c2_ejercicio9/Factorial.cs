using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ejercicio9
{
    public static class Factorial
    {
        public static double CalcularFactorial(int num)
        {
            double acum =1;
            for(int i=num; i > 0; i--)
            {
                acum*=i;
            }
            return acum;
        }
    }
}
