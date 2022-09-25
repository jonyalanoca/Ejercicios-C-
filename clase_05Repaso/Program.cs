using Empleado;
namespace clase_05Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado1 e1 = new Empleado1();
            Empleado1 e2= new Empleado1("jonathan",1200, 50000);
            Empleado1 e3 = new Empleado1("jonathan", 1200, 50000);
            Console.WriteLine(e2 == e3);
        }
    }
}