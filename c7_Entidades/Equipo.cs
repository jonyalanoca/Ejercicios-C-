using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c7_Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Contains(j))
            {
                Console.WriteLine("El jugador ya existe. No aplicaron cambios.");
            }
            else
            {
                if (e.cantidadDeJugadores > e.jugadores.Count){
                    e.jugadores.Add(j);
                    Console.WriteLine($"Se agrego un jugador al equipo.");
                }
                else
                {
                    Console.WriteLine("El equipo esta lleno.");
                }
            }
            return true;
        }
    }
}
