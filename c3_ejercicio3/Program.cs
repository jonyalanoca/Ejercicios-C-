using Entidades1;
namespace c3_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibu;
            Boligrafo boliAzul=new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo boliRojo = new Boligrafo(ConsoleColor.Red, 10);
            Console.WriteLine(boliRojo.GetTinta);
            Console.WriteLine(boliRojo.GetColor);

            boliRojo.Pintar(2, out dibu);
            Console.WriteLine(dibu);
        }
    }
}