using Entidades1;
namespace c3_ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto(-4, -1);
            Punto p2 = new Punto(-2, -3);
            Rectangulo rec1 = new Rectangulo(p1, p2);
            Console.WriteLine(rec1.Area());
            Console.WriteLine(rec1.Perimetro());
        }
    }
}