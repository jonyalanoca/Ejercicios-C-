using c7_Entidades;

namespace c7_ejercicio3
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diccionario palabras = new Diccionario(this.rtbTexto.Text);
            MessageBox.Show(palabras.MostrarTop3(),"Top 3 palabras",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}