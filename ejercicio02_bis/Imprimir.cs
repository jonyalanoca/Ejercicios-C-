using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02_bis
{
    public static class Texto
    {
        public static string Imprimir()
        {
            return Program.mensaje;
        }
        public static void Borrar()
        {
            Program.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Program.color;
            Console.WriteLine(Texto.ArmarFormatoMensaje());
        }
        private static string ArmarFormatoMensaje()
        {
            return Texto.GenerarAsteriscos(Texto.Imprimir())+"\n*"+Texto.Imprimir()+"*\n"+ Texto.GenerarAsteriscos(Texto.Imprimir());
        }
        private static string GenerarAsteriscos(string text)
        {
            string asteriscos="";
            for(int i=0; i<(text.Length)+2; i++)
            {
                asteriscos = asteriscos + "*";
            }
            return asteriscos;
        }

    }
}
