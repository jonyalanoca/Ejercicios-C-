namespace c6_ejercicio2
{
    partial class FrmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDetalles = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.grbCursos = new System.Windows.Forms.GroupBox();
            this.chbJavaScript = new System.Windows.Forms.CheckBox();
            this.chbCplusplus = new System.Windows.Forms.CheckBox();
            this.chbCSharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lsbPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.grbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grbGenero.SuspendLayout();
            this.grbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetalles
            // 
            this.grbDetalles.Controls.Add(this.nudEdad);
            this.grbDetalles.Controls.Add(this.txtDir);
            this.grbDetalles.Controls.Add(this.txtNombre);
            this.grbDetalles.Controls.Add(this.lblEdad);
            this.grbDetalles.Controls.Add(this.lblDir);
            this.grbDetalles.Controls.Add(this.lblNombre);
            this.grbDetalles.Location = new System.Drawing.Point(12, 12);
            this.grbDetalles.Name = "grbDetalles";
            this.grbDetalles.Size = new System.Drawing.Size(182, 133);
            this.grbDetalles.TabIndex = 0;
            this.grbDetalles.TabStop = false;
            this.grbDetalles.Text = "Detalles del usuario";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(65, 86);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 5;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(65, 58);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(100, 23);
            this.txtDir.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 88);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(6, 61);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(57, 15);
            this.lblDir.TabIndex = 1;
            this.lblDir.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rdbNoBinario);
            this.grbGenero.Controls.Add(this.rdbFemenino);
            this.grbGenero.Controls.Add(this.rdbMasculino);
            this.grbGenero.Location = new System.Drawing.Point(222, 12);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(113, 103);
            this.grbGenero.TabIndex = 1;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(13, 72);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdbNoBinario.TabIndex = 2;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(13, 47);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(13, 22);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grbCursos
            // 
            this.grbCursos.Controls.Add(this.chbJavaScript);
            this.grbCursos.Controls.Add(this.chbCplusplus);
            this.grbCursos.Controls.Add(this.chbCSharp);
            this.grbCursos.Location = new System.Drawing.Point(222, 121);
            this.grbCursos.Name = "grbCursos";
            this.grbCursos.Size = new System.Drawing.Size(114, 100);
            this.grbCursos.TabIndex = 2;
            this.grbCursos.TabStop = false;
            this.grbCursos.Text = "Cursos";
            // 
            // chbJavaScript
            // 
            this.chbJavaScript.AutoSize = true;
            this.chbJavaScript.Location = new System.Drawing.Point(15, 75);
            this.chbJavaScript.Name = "chbJavaScript";
            this.chbJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chbJavaScript.TabIndex = 2;
            this.chbJavaScript.Text = "JavaScript";
            this.chbJavaScript.UseVisualStyleBackColor = true;
            // 
            // chbCplusplus
            // 
            this.chbCplusplus.AutoSize = true;
            this.chbCplusplus.Location = new System.Drawing.Point(15, 47);
            this.chbCplusplus.Name = "chbCplusplus";
            this.chbCplusplus.Size = new System.Drawing.Size(50, 19);
            this.chbCplusplus.TabIndex = 1;
            this.chbCplusplus.Text = "C++";
            this.chbCplusplus.UseVisualStyleBackColor = true;
            // 
            // chbCSharp
            // 
            this.chbCSharp.AutoSize = true;
            this.chbCSharp.Location = new System.Drawing.Point(15, 22);
            this.chbCSharp.Name = "chbCSharp";
            this.chbCSharp.Size = new System.Drawing.Size(41, 19);
            this.chbCSharp.TabIndex = 0;
            this.chbCSharp.Text = "C#";
            this.chbCSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(222, 230);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 24);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lsbPais
            // 
            this.lsbPais.FormattingEnabled = true;
            this.lsbPais.ItemHeight = 15;
            this.lsbPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lsbPais.Location = new System.Drawing.Point(12, 178);
            this.lsbPais.Name = "lsbPais";
            this.lsbPais.Size = new System.Drawing.Size(182, 79);
            this.lsbPais.TabIndex = 4;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(13, 160);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "País";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 268);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lsbPais);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grbCursos);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.grbDetalles);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.grbDetalles.ResumeLayout(false);
            this.grbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbCursos.ResumeLayout(false);
            this.grbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbDetalles;
        private GroupBox grbGenero;
        private RadioButton rdbNoBinario;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private GroupBox grbCursos;
        private CheckBox chbJavaScript;
        private CheckBox chbCplusplus;
        private CheckBox chbCSharp;
        private Button btnIngresar;
        private NumericUpDown nudEdad;
        private TextBox txtDir;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblDir;
        private Label lblNombre;
        private ListBox lsbPais;
        private Label lblPais;
    }
}