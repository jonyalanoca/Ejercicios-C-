using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ejercicio5
{
    public static class Tabla
    {
        public static string MostrarTabla(int numero)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }
            return sb.ToString();
        }


    }
}
