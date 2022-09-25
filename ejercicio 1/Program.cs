namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            int valorMinimo=0;
            int valorMaximo=0;
            double promedio = 0;
            bool validado = false;
            for(int i=0; i < 10; i++){
                validado = false;
                while (validado == false)
                {
                    Console.WriteLine("Ingrese un numero entre -100 y 100");
                    numero=int.Parse(Console.ReadLine());
                    validado = Validador.Validar(numero, -100, 100);
                }
                
                if (i == 0)
                {
                    valorMinimo = numero;
                    valorMaximo = numero;
                }
                else
                {
                    if (numero > valorMaximo)
                    {
                        valorMaximo = numero;
                    }
                    if (numero < valorMinimo)
                    {
                        valorMinimo = numero;
                    }
                }
                promedio += (double)numero;
            }
            Console.WriteLine("El numero maximo es: {0}", valorMaximo);
            Console.WriteLine("El numero minimo es: {0}", valorMinimo);
            Console.WriteLine("El promedio es: {0}", promedio / 10);
        }
    }
}