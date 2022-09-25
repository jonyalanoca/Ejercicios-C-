namespace ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int anioInicio;
            int anioFin;

            bool anioVisiesto = false;
            Console.Write("Ingrese el anio de inicio: ");
            anioInicio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el anio de fin: ");
            anioFin = int.Parse(Console.ReadLine());
            for(int i = anioInicio; i <= anioFin; i++)
            {
                if(i % 400 == 0 || (i%4==0 && i%100!=0))
                {
                    Console.WriteLine($"{i} es bisiesto.");
                }   
            }
                
        }
    }
}