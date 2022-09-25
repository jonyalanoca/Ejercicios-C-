using System.Text;

namespace FRMEj1
{
    public partial class FRMInicio : Form
    {
        public FRMInicio()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se deben completar los sigiente campos:");
            if (String.IsNullOrWhiteSpace(this.txtNombre.Text)|| String.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                if (String.IsNullOrWhiteSpace(this.txtNombre.Text))
                {
                    sb.AppendLine("Nombre");
                }
                if (String.IsNullOrWhiteSpace(this.txtApellido.Text))
                {
                    sb.AppendLine("Apellido");
                }
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                FRMSaludo frmSaludo = new FRMSaludo(this.txtNombre.Text, this.txtApellido.Text, this.cmbMateria.Text);
                frmSaludo.ShowDialog();
            }
        }

        private void FRMInicio_Load(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = 0;
        }
        
    }
}