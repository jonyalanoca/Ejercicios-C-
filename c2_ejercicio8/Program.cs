using System.Text;

namespace c2_ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
            DateTime dt;
            Console.Write("Ingrese el dia de nacimiento: ");
            dia=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el anio de nacimiento: ");
            anio = int.Parse(Console.ReadLine());
            dt = new DateTime(anio, mes, dia);

            Console.WriteLine(Dias.DiasVividos(dt.ToString()));
        }
    }
}