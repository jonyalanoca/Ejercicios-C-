using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ejercicio8
{
    public static class Dias
    {
       public static int DiasVividos(string tiempo)
        {
            DateTime dt = DateTime.Parse(tiempo);
            DateTime dtHoy = DateTime.Now;
            TimeSpan dif = dtHoy - dt;
            return dif.Days;
        }
    }
}
