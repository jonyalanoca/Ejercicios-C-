using Entidades1;
namespace c3_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("jonathan","alanoca","1n");
            Estudiante estudiante2 = new Estudiante("Gerardo", "aduviri", "2n");
            Estudiante estudiante3 = new Estudiante("juan", "gomez","3n");
            estudiante1.SetNotaPrimerParcial(5);
            estudiante1.SetNotaSegundoParcial(6);

            estudiante2.SetNotaPrimerParcial(3);
            estudiante2.SetNotaSegundoParcial(6);

            estudiante3.SetNotaPrimerParcial(1);
            estudiante3.SetNotaSegundoParcial(2);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}