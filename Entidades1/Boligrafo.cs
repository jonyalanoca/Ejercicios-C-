using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Boligrafo
    {
        public const short cantidadDeTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo()
        {
            this.color = ConsoleColor.White;
            this.tinta = 0;
        }
        public Boligrafo(ConsoleColor color, short tinta):this()
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor
        {
            get { return color; }
        }
        public short GetTinta
        {
            get { return tinta; }
        }
        private void SetTinta(short tinta)
        {
            if (tinta >=0 && tinta<=cantidadDeTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
        public void Recargar()
        {
            SetTinta(100);
        }
        public bool Pintar(short gasto,out string dibujo)
        {
            dibujo = "";
            if (gasto>=0 && gasto <= this.tinta)
            {
                Console.ForegroundColor = this.color;
                int diferencia =  this.tinta - gasto;
                SetTinta((short)diferencia);
                if(this.tinta == 0)
                {
                    Console.WriteLine("hols");
                    dibujo = "";
                }else if(this.tinta==10 && gasto == 2)
                {
                    
                    dibujo = "**";
                }
                else if(this.tinta==3 && gasto == 10)
                {
                    dibujo = "***";
                }
            }
            
            return false;
        }
    }
}
