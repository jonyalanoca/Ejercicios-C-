using c8_ejercicio1_Entidades;

namespace c8_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VeiculoTerreste v1 = new VeiculoTerreste(4, 2, EColores.Azul);
            Automovil auto1= new Automovil(4, 2, EColores.Azul, 5, 6);
            Camion camion1 = new Camion(4, 2, EColores.Blanco, 6, 1000);
            Moto moto1 = new Moto(2, 0, EColores.Negro, 120);

            Console.WriteLine(auto1.Mostrar());
            Console.WriteLine(camion1.Mostrar());
            Console.WriteLine(moto1.Mostrar());
        }
    }
}