using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_Entidades
{
    public class Perro: Animal
    {
        private string raza;
        public Perro(string nombre, int patas, bool pelaje):base(nombre, patas, pelaje)
        {

        }
        public Perro(string nombre, int patas, bool pelaje, string raza) : this(nombre, patas, pelaje)
        {
            this.raza = raza;
        }

        public string ladrar()
        {
            return "hola soy el perro" + this.nombre;
        }
            
    }
}
