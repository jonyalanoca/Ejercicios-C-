
namespace ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char respuesta = 'n';
            int numero = 0;
            do
            {
                Console.WriteLine("Ingrese un numero entero.");
                numero += int.Parse(Console.ReadLine());
                Console.WriteLine("Desea agregar mas numeros? (s/n)");
                respuesta=char.Parse(Console.ReadLine());
            } while (Validador.ValidarRespuesta(respuesta));
            Console.WriteLine("La suma total es de: {0}",numero);
        }
    }
}