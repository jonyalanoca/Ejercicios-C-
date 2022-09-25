using c7_Entidades;
namespace c7_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador(12, "a",10,2);
            Jugador jugador2 = new Jugador(13, "b", 20, 1);
            Jugador jugador3 = new Jugador(14, "c", 30, 3);
            Jugador jugador4 = new Jugador(15, "d", 40, 5);
            Jugador jugador5 = new Jugador(16, "e", 50, 7);

            Console.WriteLine(jugador4.MostrarDatos());
            Equipo equipo1 = new Equipo(3,"sacachispa");
            bool asd=equipo1 + jugador1;
            asd = equipo1 + jugador1;
            asd = equipo1 + jugador2;
            asd = equipo1 + jugador3;
            asd = equipo1 + jugador4;
        }
    }
}