using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        static Estudiante()
        {
            Estudiante.random = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial=nota;
        }
        private float CalcularPromedio()
        {

            return ((float)this.notaPrimerParcial+this.notaSegundoParcial)/2;
        }
        public double CalcularNotaFinal()
        {
            double notaFinal=-1;
            if (CalcularPromedio()>=4)
            {
                notaFinal = random.Next(6, 11);
            }
            return notaFinal;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del alumno");
            sb.AppendLine($"Nombre: {this.nombre}. Apellido: {this.apellido}, legajo: {this.legajo}");
            sb.AppendLine($"Nota 1er parcial: {this.notaPrimerParcial}. Nota 2do parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"El promedio obtenido es: {CalcularPromedio()}");
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"La nota final es: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }
}
