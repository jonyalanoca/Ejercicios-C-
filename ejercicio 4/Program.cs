namespace ejercicio_4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int perfectos = 0;
            int numero;
            int acumDivisores=0;
            do
            {
                acumDivisores = 0;
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                for(int i =1; i<numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acumDivisores += i;

                    }

                }
                if (acumDivisores == numero)
                {
                    perfectos++;
                    Console.WriteLine("El numero {0} es perfecto.", numero);
                }
                else
                {
                    Console.WriteLine("El numero {0} no es perfecto.", numero);
                }

            }while(perfectos != 3);
        }

    }
}
