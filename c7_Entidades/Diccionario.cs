using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c7_Entidades
{
    public class Diccionario
    {
        private Dictionary<string, int> diccDePalabras;
        public Diccionario()
        {
            this.diccDePalabras= new Dictionary<string, int>();
        }
        public Diccionario(string palabra) : this()
        {
            string[] array = palabra.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (this.diccDePalabras.ContainsKey(array[i]))
                {
                    diccDePalabras[array[i]]++;
                }
                else
                {
                    this.diccDePalabras.Add(array[i], 1);
                }

            }
        }
        public string MostrarTop3()
        {
            StringBuilder sb = new StringBuilder();
            int contador = 0;
            var diccSorteado= from entry in this.diccDePalabras orderby entry.Value descending select entry;
            foreach (var i in diccSorteado) 
            {
                if (contador < 3)
                {
                    sb.AppendLine($"{i.Key}  {i.Value}");
                    contador++;
                }
                else
                {
                    break;
                }
            }
           return sb.ToString();
        }
        
    }
    
}
