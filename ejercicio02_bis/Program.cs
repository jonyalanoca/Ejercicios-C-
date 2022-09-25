namespace ejercicio02_bis
{
    internal class Program
    {
        public static string mensaje;
        public static ConsoleColor color;
        static void Main(string[] args)
        {
            Program.mensaje = "hola mundo";
            Console.WriteLine(Texto.Imprimir());
            Texto.Borrar();
            Console.WriteLine(Texto.Imprimir());

            Program.mensaje = "hola mundo c#";
            Program.color = ConsoleColor.Red;
            Texto.ImprimirEnColor();
            Console.ResetColor();
            Console.WriteLine(Texto.Imprimir());
        }
    }
}