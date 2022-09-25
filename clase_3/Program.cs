namespace clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal1;
            //animal1 = new Animal();
            //Animal animal2;
            //animal2 = new Animal();
            //animal1.nombre = "pepe";
            //Console.WriteLine(animal1.Hablar());

            //animal2.nombre = "fiufiu";
            //Console.WriteLine(animal2--.Hablar());
            Animal animal1;
            animal1 = new Animal("pepe", 12,"perro");
            Console.WriteLine(animal1.Hablar());
        }
    }
}