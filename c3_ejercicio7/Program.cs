using Entidades1;
namespace c3_ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Mascota mascota1 = new Mascota("Luna", "perro", dt);
            List<Mascota> listaMascotas1 = new List<Mascota> { mascota1 };
            Duenio duenio1 = new Duenio("jonathan", "alanoca", 1125607164, listaMascotas1);

            List<EVacuna> listaVacunas1 = new List<EVacuna>() { EVacuna.TripleFelina };
            Mascota mascota2 = new Mascota("garfiel", "gato", dt, listaVacunas1);
            List<Mascota> listaMascotas2 = new List<Mascota> { mascota2 };
            Duenio duenio2 = new Duenio("Karen", "alanoca", 119837726,listaMascotas2);


            Mascota mascota3 = new Mascota("Tomas", "gato", dt);
            List<EVacuna> listaVacunas3 = new List<EVacuna>() { EVacuna.Rabia };
            Mascota mascota4 = new Mascota("Rufo", "Perro", dt,listaVacunas3);
            List<Mascota> listaMascotas3 = new List<Mascota> { mascota3, mascota4 };
            Duenio duenio3 = new Duenio("Ramon", "alanoca", 152337726, listaMascotas3);

            Console.WriteLine(duenio1.Mostrar());
            Console.WriteLine(duenio2.Mostrar());
            Console.WriteLine(duenio3.Mostrar());


        }
    }
}