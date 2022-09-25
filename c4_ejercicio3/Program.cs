using c4_Entidades;
namespace c4_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante(3, 1);
            Producto p1 = new Producto("pepsi", "pep123", (float)18.5);
            Producto p2 = new Producto("coca", "coca123", (float)11.5);
            Producto p3 = new Producto("manaos", "mana123", (float)20.5);
            Producto p4 = new Producto("crush", "cru123", (float)10.75);
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }

            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
        }
    }
}