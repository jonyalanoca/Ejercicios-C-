namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool validado = false;
            do
            {
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    validado = true;
                    break;
                }
                Console.WriteLine("Error.Reingrese de nuevo.");
            }while (validado == false);
            Console.WriteLine("El cuadrado del numero es:{0}", Math.Pow(numero, 2));
            Console.WriteLine("El cubo del numero es:{0}", Math.Pow(numero,3));
        }
    }
}