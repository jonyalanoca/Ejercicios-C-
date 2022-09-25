using Entidades1;
namespace ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entidades1.Cuenta cuenta1;
            cuenta1 = new Entidades1.Cuenta("jonathan" ,1200);
            Console.WriteLine(cuenta1.MostrarDatos());
            cuenta1.IngresarMonto(-1200);
            Console.WriteLine(cuenta1.MostrarDatos());
            cuenta1.RetirarMonto(4000);
            Console.WriteLine(cuenta1.MostrarDatos());
        }
    }
}