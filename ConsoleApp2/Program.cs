using c7_Entidades;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<int> list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(Random1.GenerarNumeroAleatorio());
            }
            foreach (int i in list)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("");
            list.Sort();
            list.Reverse();
            foreach(int i in list)
            {
                if (i > 0)
                {
                    Console.Write($" {i}");
                }
               
            }
            Console.WriteLine("");
            list.Sort();
            foreach (int i in list)
            {
                if (i < 0)
                {
                    Console.Write($" {i}");
                }
            }

        }
    }
}