using c7_Entidades;
namespace c7_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            Stack<int> pila1 = new Stack<int>();
            Queue<int> cola1 = new Queue<int>();

            for(int i =0; i < 20; i++)
            {
                lista1.Add(Random1.GenerarNumeroAleatorio());
                pila1.Push(Random1.GenerarNumeroAleatorio());
                cola1.Enqueue(Random1.GenerarNumeroAleatorio());
            }
            Console.WriteLine(Colecciones.MostrarColeccion(lista1));
            Console.WriteLine(Colecciones.MostrarColeccion(pila1));
            Console.WriteLine(Colecciones.MostrarColeccion(cola1));

        }
    }
}