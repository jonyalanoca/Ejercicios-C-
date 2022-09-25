using c7_Entidades;
namespace c7_ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(100, "cascada");
            AutoF1 a2 = new AutoF1(150, "catalina");
            AutoF1 a3 = new AutoF1(250, "cat");
            AutoF1 a4 = new AutoF1(200, "olmeca");
            AutoF1 a5 = new AutoF1(400, "pad");
            Competencia compet = new Competencia(4, 3);
            if (compet + a1) { Console.WriteLine("Se agrego un competidor."); } else {Console.WriteLine("Sin cambios.") ; }
            if (compet + a1) { Console.WriteLine("Se agrego un competidor."); } else { Console.WriteLine("Sin cambios."); }
            if (compet + a2) { Console.WriteLine("Se agrego un competidor."); } else { Console.WriteLine("Sin cambios."); }
            if (compet + a3) { Console.WriteLine("Se agrego un competidor."); } else { Console.WriteLine("Sin cambios."); }
            if (compet + a4) { Console.WriteLine("Se agrego un competidor."); } else { Console.WriteLine("Sin cambios."); }
            if (compet + a5) { Console.WriteLine("Se agrego un competidor."); } else { Console.WriteLine("Sin cambios."); }
            if (compet - a1) { Console.WriteLine("Se borro un competidor."); } else { Console.WriteLine("Sin cambios."); }
            if (compet - a5) { Console.WriteLine("Se borro un competidor."); } else { Console.WriteLine("Sin cambios."); }

            Console.WriteLine(compet.MostrarDatos());
            
        }
    }
}