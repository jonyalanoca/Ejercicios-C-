namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int grupo1;
            int grupo2;
            int numeroMedio=2;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            do
            {
                grupo1 = 0;
                for (int i = 1; i < numeroMedio; i++)
                {
                    grupo1 += i;
                }
                grupo2 = 0;
                for (int i = numeroMedio + 1; i <= numero; i++)
                {
                    grupo2 += i;
                }
                if (grupo2 == grupo1)
                {
                    Console.WriteLine("Encontramos un centro numerico: {0}", numeroMedio);
                    break;
                }
                numeroMedio++;
            } while (numeroMedio < numero);
            if (numeroMedio == numero)
            {
                Console.WriteLine("No se encontro un numero centrico.");
            }
                
        }
    }
}