namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salir = "no";
            string volver = "no";
            bool esPrimo = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero.");
                if(int.TryParse(Console.ReadLine(),out int numero)){
                    for (int i = 2; i < numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            Console.WriteLine("El numero no es primo");
                            esPrimo = false;
                            break;
                        }
                        
                    }
                    if(esPrimo==true){
                        Console.WriteLine("El numero es primo");
                    }
                    Console.WriteLine("Para volver ejecutar el programa ingrese 'si'");
                    volver = Console.ReadLine();
                    if (String.Equals(volver, "si"))
                    {
                        esPrimo = true;
                        volver = "no";
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("No se ingreso un numero.\nSi desea salir escriba 'salir'");
                if (Console.ReadLine() == "salir")
                {
                    Environment.Exit(0);
                }
            } while (String.Equals(volver,"no"));
        }
    }
}