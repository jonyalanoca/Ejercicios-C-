namespace c8_Entidades
{
    public class Animal
    {
        protected string nombre;
        private int patas;
        private bool pelaje;
        public Animal(string nombre, int patas, bool pelaje)
        {
            this.nombre = nombre;
            this.patas = patas;
            this.pelaje = pelaje;
        }
        public string Saludar()
        {
            return $"hola soy {this.nombre}";
        }
    }
}