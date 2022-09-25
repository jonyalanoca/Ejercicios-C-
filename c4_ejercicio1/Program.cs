using c4_Entidades;
namespace c4_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1= new Sumador();
            Sumador sumador2 = new Sumador();
            Console.WriteLine(sumador1.Sumar("Jonathan", "Alanoca"));
           
            bool numero = sumador1 | sumador2;
            Console.WriteLine(numero);
            

        }
    }
}