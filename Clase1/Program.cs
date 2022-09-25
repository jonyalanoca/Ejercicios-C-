namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double numeroMaximo =0;
            double numeroMinimo =0;
            double promedio =0;

            for(int i = 0; i < 5; i++){
                numero= int.Parse(Console.ReadLine());
                if (i == 0){
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                }
                else
                {
                    if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }

                promedio += (float)numero;

            }
            Console.WriteLine("El numero maximo es: {0}", numeroMaximo);
            Console.WriteLine("El numero minimo es: {0}", numeroMinimo);
            Console.WriteLine("El promedio es: {0}", promedio/5);



        }
    }
}