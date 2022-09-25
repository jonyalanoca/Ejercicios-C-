using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3
{
    public class Animal
    {
        //ATRIBUTOS
        public string nombre;
        public int edad;
        public string tipoDeAnimal;
        static int contador;

       //METODOS
       static Animal()
        {
            Animal.contador=0;
        }
       public Animal()
        {
            this.nombre = "olvidado";
            this.edad = 112;
            this.tipoDeAnimal = "Adios";
        }
       public Animal(string nombre , int edad , string tipoDeAnimal)
        {
            Animal.contador++;            
            this.nombre = nombre;
            this.edad = edad;
            this.tipoDeAnimal = tipoDeAnimal;

        }
       public string Hablar()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("Mi nombre es: ");
            sb.AppendLine(this.nombre);
            sb.Append("Tengo ");
            sb.Append(this.edad.ToString());
            sb.AppendLine(" anios");
            sb.Append("Y soy un ");
            sb.AppendLine(this.tipoDeAnimal);

            return sb.ToString();
        }
    }
}
