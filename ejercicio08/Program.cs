namespace ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese la altura del triangulo:");
            numero=int.Parse(Console.ReadLine());
            for(int i = 1; i <= numero; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}