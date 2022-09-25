using Entidades1;
namespace ejercicio02_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Jonathan", "02/05/1993", 37377700);
            Persona persona2 = new Persona("Gerardo", "01/12/2010", 20377700);
            Persona persona3 = new Persona("Andrea", "18/04/1992", 28377700);
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());

        }
    }
}