namespace ejecicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int vacio;
            Console.Write("Ingrese la altura del triangulo:");
            numero=int.Parse(Console.ReadLine());
            vacio = numero - 1;
           for(int i = 0; i < numero; i++)
            { 
                for(int j=0; j < numero+i; j++)
                {
                    if (j<vacio)
                    {
                        Console.Write(" ");
                    }
                    else{
                        Console.Write("*");
                    }
                }
                vacio--;
                Console.Write("\n");
            }
        }
    }
}