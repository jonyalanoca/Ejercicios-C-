namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            double valorPorhoras;
            string nombre;
            int antiguedad;
            int horasMes;
            double cuenta=0;
            do
            {
                Console.Clear();
                Console.Write("Ingrese el nombre del empleado: ");
                nombre= Console.ReadLine();
                Console.Write("Ingrese el valor por hora del empleado: ");
                valorPorhoras=double.Parse(Console.ReadLine());
                Console.Write("Ingrese el la antiguedad  del empleado: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas en el mes del empleado: ");
                horasMes = int.Parse(Console.ReadLine());
                Console.WriteLine("INFORMES");
                cuenta = ((float)(valorPorhoras * horasMes) + (antiguedad * 150)) - ((((float)(valorPorhoras * horasMes) + (antiguedad * 150)) * 13) / 100);
                Console.WriteLine("El importe a cobrar por el empleado {0} es: ${1}", nombre, cuenta);
                Console.WriteLine("\n\nDesea cargar otro empleado?(s/n):");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's');
        }
    }
}