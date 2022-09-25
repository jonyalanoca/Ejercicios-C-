namespace FRMEj1
{
    partial class FRMSaludo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblHolaWF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.Location = new System.Drawing.Point(56, 88);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 21);
            this.lblTexto.TabIndex = 0;
            // 
            // lblHolaWF
            // 
            this.lblHolaWF.AutoSize = true;
            this.lblHolaWF.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHolaWF.Location = new System.Drawing.Point(161, 22);
            this.lblHolaWF.Name = "lblHolaWF";
            this.lblHolaWF.Size = new System.Drawing.Size(219, 25);
            this.lblHolaWF.TabIndex = 1;
            this.lblHolaWF.Text = "¡Hola, Windows Forms!";
            // 
            // FRMSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 166);
            this.Controls.Add(this.lblHolaWF);
            this.Controls.Add(this.lblTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRMSaludo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.Load += new System.EventHandler(this.FRMSaludo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTexto;
        private Label lblHolaWF;
    }
}