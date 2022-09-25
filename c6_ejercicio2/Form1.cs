using c6_Entidades;
using System.Text;

namespace c6_ejercicio2
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string sexo = SaberSexo();
            string clases = SaberClases();
                Ingresante ingresante= new Ingresante(clases,txtDir.Text,(int)nudEdad.Value,sexo,txtNombre.Text,lsbPais.Text);
            MessageBox.Show(ingresante.Mostrar(), "Atencion", MessageBoxButtons.OK);
        }

        private string SaberSexo()
        {
            string sexo;
            if(rdbMasculino.Checked == true)
            {
                sexo = "Masculino";
            }else if (rdbFemenino.Checked == true)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "No binario";
            }
            return sexo;
        }
        private string SaberClases()
        {
            StringBuilder sb = new StringBuilder();
            if (chbCSharp.Checked == true)
            {
                sb.Append($"{chbCSharp.Text} ");
            }
            if (chbJavaScript.Checked == true)
            {
                sb.Append($"{chbJavaScript.Text} ");
            }
            if (chbCplusplus.Checked == true)
            {
                sb.Append($"{chbCplusplus.Text} ");
            }
            return sb.ToString();
        }
        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}