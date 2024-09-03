namespace CreditSimulationApp.WEB
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnCrearCredito; // Declaración del botón Crear Crédito

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCliente = new DataGridView();
            btnVerCliente = new Button();
            btnAgregarCliente = new Button();
            btnEliminarCliente = new Button();
            btnCrearCredito = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(42, 12);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(583, 277);
            dgvCliente.TabIndex = 0;
            // 
            // btnVerCliente
            // 
            btnVerCliente.Location = new Point(42, 319);
            btnVerCliente.Name = "btnVerCliente";
            btnVerCliente.Size = new Size(75, 23);
            btnVerCliente.TabIndex = 1;
            btnVerCliente.Text = "Ver Cliente";
            btnVerCliente.UseVisualStyleBackColor = true;
            btnVerCliente.Click += btnVerCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(152, 319);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(100, 23);
            btnAgregarCliente.TabIndex = 2;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(439, 319);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(100, 23);
            btnEliminarCliente.TabIndex = 3;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnCrearCredito
            // 
            btnCrearCredito.Location = new Point(293, 319);
            btnCrearCredito.Name = "btnCrearCredito";
            btnCrearCredito.Size = new Size(100, 23);
            btnCrearCredito.TabIndex = 4;
            btnCrearCredito.Text = "Crear Crédito";
            btnCrearCredito.UseVisualStyleBackColor = true;
            btnCrearCredito.Click += BtnCrearCredito_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 371);
            Controls.Add(btnCrearCredito);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(btnVerCliente);
            Controls.Add(dgvCliente);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
        }
    }
}
