using System.Net.Sockets;
using System.Text;

namespace c4_Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador()
        {
            cantidadSumas = 0;
        }
        public Sumador(int cantidadSumas): this()
        {
            this.cantidadSumas = cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            StringBuilder sb=new StringBuilder();
            sb.Append($"{a} {b}");
            return sb.ToString();
        }
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator+(Sumador s1,Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator|(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }
    }
}