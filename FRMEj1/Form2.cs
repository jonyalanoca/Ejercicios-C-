using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMEj1
{
    public partial class FRMSaludo : Form
    {
        
        public FRMSaludo()
        {
            InitializeComponent();
        }

        private void FRMSaludo_Load(object sender, EventArgs e)
        {

        }
        public FRMSaludo(string nombre, string apellido,string materia) : this()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Soy {nombre} {apellido} y mi materia favorita es {materia}");
            this.lblTexto.Text = sb.ToString();
        }
    }
}
