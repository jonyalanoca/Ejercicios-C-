using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        private void SetArea()
        {
            int base1=Math.Abs(Math.Abs(this.vertice1.GetX()) - Math.Abs(this.vertice3.GetX()));
            int altura=Math.Abs(Math.Abs(this.vertice1.GetY()) - Math.Abs(this.vertice3.GetY()));
            this.area=(float)base1 * altura;
        }
        private void SetPerimetro()
        {
            int base1 = Math.Abs(Math.Abs(this.vertice1.GetX()) - Math.Abs(this.vertice3.GetX()));
            int altura = Math.Abs(Math.Abs(this.vertice1.GetY()) - Math.Abs(this.vertice3.GetY()));
            this.perimetro = (float)base1 * altura / 2;
        }
        public float Area()
        {
            SetArea();
            return this.area;
        }
        public float Perimetro()
        {
            SetPerimetro();
            return this.perimetro;
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice1.GetY(), vertice3.GetX());
        }
    }
}
