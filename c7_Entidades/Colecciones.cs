using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c7_Entidades
{
    public static class Colecciones
    {
        public static string  MostrarColeccion(List<int> col1)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int i in col1)
            {
                sb.Append($"{i} ");
            }
            sb.AppendLine("");
            return sb.ToString();
        }
        public static string MostrarColeccion(Stack<int> col1)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in col1)
            {
                sb.Append($"{i} ");
            }
            sb.AppendLine("");
            return sb.ToString();
        }
        public static string MostrarColeccion(Queue<int> col1)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in col1)
            {
                sb.Append($"{i} ");
            }
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}
