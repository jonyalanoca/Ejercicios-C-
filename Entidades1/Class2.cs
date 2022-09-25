using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Persona
    {
        private string nombre;
        private string fechaDeNacimiento;
        private int dni;
        public Persona()
        {
            this.nombre = "Sin nombre";
            this.fechaDeNacimiento = "0/0/0";
            this.dni = 0;
        }
        public Persona(string nombre, string fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        private double CalcularEdad(string nacimiento)
        {
            double diferencia;
            DateTime dt = DateTime.Parse(nacimiento);
            DateTime dtNow = DateTime.Now;
            diferencia = dtNow.Year - dt.Year;
            if (dtNow.Month < dt.Month)
            {
                diferencia--;
            }
            return diferencia;
        }
        public string Mostrar()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"Hola {this.nombre} con dni {this.dni} y tiene {CalcularEdad(this.fechaDeNacimiento)} anios");
            return st.ToString();
        }
        public string EsMayorDeEdad()
        {
            if (CalcularEdad(this.fechaDeNacimiento) > 17)
            {
                return "Es mayor de edad";
            }
            return "Es menor";

        }
    }
}
