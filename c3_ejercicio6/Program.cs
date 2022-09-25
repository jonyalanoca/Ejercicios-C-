using Entidades1;
namespace c3_ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductores cond1 = new Conductores("jony", 110, 20, 30, 40, 50, 60, 70);
            Conductores cond2 = new Conductores("Olga", 10, 20, 30, 40, 50, 60, 70);
            Conductores cond3 = new Conductores("Gera", 210, 20, 30, 40, 50, 60, 70);
            Transporte empresa1 = new Transporte();
            empresa1 += cond1;
            empresa1 += cond2;
            empresa1 += cond3;
            Console.WriteLine(empresa1.ConductorConMasKM());
        }
    }
}