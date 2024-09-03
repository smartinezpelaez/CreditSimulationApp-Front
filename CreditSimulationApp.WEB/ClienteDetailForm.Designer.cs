namespace CreditSimulationApp.WEB
{
    partial class ClienteDetailForm
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
            lblNombre = new Label();
            lblEmail = new Label();
            dgvCreditos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCreditos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 10);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // dgvCreditos
            // 
            dgvCreditos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditos.Location = new Point(10, 70);
            dgvCreditos.Name = "dgvCreditos";
            dgvCreditos.Size = new Size(500, 200);
            dgvCreditos.TabIndex = 2;
            // 
            // ClienteDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 318);
            Controls.Add(dgvCreditos);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Name = "ClienteDetailForm";
            Text = "ClienteDetailForm";
            ((System.ComponentModel.ISupportInitialize)dgvCreditos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEmail;
        private DataGridView dgvCreditos;
    }
}