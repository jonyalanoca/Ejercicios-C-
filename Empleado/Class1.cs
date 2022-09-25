namespace Empleado
{
    public class Empleado1
    {
        #region atributos
        private string nombre;
        private int legajo;
        private float sueldo;
        #endregion
        #region Constructores
        public Empleado1()
        {
            this.nombre = "nn";
            this.legajo = 1000;
            this.sueldo = 0;
        }
        public Empleado1(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Empleado1(string nombre, int legajo, float sueldo) : this(nombre)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }
        #endregion
        #region GetersAndSeters
        public string Nombre
        {
            get { return this.nombre;}
            set { this.nombre = value; }
        }
        // ahora se maneja igualmente que una atributo (tipo propiedad)
        #endregion
        #region metodos
        public string Saludar()
        {
            return $"hola soy{this.nombre}";
        }
        public string Saludar(string varNombre)
        {
            return $"hola soy{varNombre}";
        }

        #endregion
        public static bool operator ==(Empleado1 e1, Empleado1 e2)
        {
            return e1.nombre == e2.nombre && e1.legajo == e2.legajo;
           
        }
        public static bool operator !=(Empleado1 e1, Empleado1 e2)
        {
            return !(e1 == e2);                
        }

    }
}