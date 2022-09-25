using System.Text;

namespace c6_Entidades
{
    public class Ingresante
    {
        private string cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;
        public Ingresante(string cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"El integrante {this.nombre} de edad {this.edad}, genero {this.genero}, direccion {this.direccion}, pais {this.pais} esta en el curso {this.cursos}");
            return sb.ToString();
        }
    }
}