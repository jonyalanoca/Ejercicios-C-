using Empleado;
using System.Text;

namespace prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> lista1= new List<int> { 1, 4, 4,5,6 };
            lista1.Sort(pFuncDescendente);
            foreach(var i in lista1)
            {
                Console.WriteLine(i);
            }

        }

        private static int pFuncDescendente(int x, int y)
        {
            if (x < y)
            {
                return 1;
            }
            return -1;
        }
    }
}