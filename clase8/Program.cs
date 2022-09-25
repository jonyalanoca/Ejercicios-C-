using c8_Entidades;
namespace clase8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro toby = new Perro("toby", 4, true);
            Console.WriteLine(toby.ladrar());

        }
    }
}