namespace c2_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char salir = 'n';
            int num1;
            int num2;
            char op;
            while(salir != 's')
            {
                Console.Write("Ingrese el primer numero: ");
                num1=int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el operador (+ - / *): ");
                op = char.Parse(Console.ReadLine());
                Console.WriteLine(Calculadora.Calcular(num1, num2, op));
                Console.Write("Desea hacer otra operacion? (s/n): ");
                salir = char.Parse(Console.ReadLine());
            }
        }
    }
}