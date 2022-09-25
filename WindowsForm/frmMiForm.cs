namespace WindowsForm
{
    public partial class frmMiForm : Form
    {
        public frmMiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtBox.Text;
            MessageBox.Show($"hola{nombre} como estas.", "bienbenido", MessageBoxButtons.OK);
        }
    }
}