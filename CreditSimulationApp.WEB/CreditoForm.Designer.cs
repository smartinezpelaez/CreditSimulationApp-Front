namespace CreditSimulationApp.WEB
{
    partial class CreditoForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "CreditoForm"; this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblTasaInteres = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.lblPlazoMeses = new System.Windows.Forms.Label();
            this.txtPlazoMeses = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.chkPagado = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 15);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(42, 13);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(100, 12);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // lblTasaInteres
            // 
            this.lblTasaInteres.AutoSize = true;
            this.lblTasaInteres.Location = new System.Drawing.Point(12, 45);
            this.lblTasaInteres.Name = "lblTasaInteres";
            this.lblTasaInteres.Size = new System.Drawing.Size(79, 13);
            this.lblTasaInteres.TabIndex = 2;
            this.lblTasaInteres.Text = "Tasa de Interés:";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(100, 42);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(200, 20);
            this.txtTasaInteres.TabIndex = 3;
            // 
            // lblPlazoMeses
            // 
            this.lblPlazoMeses.AutoSize = true;
            this.lblPlazoMeses.Location = new System.Drawing.Point(12, 75);
            this.lblPlazoMeses.Name = "lblPlazoMeses";
            this.lblPlazoMeses.Size = new System.Drawing.Size(71, 13);
            this.lblPlazoMeses.TabIndex = 4;
            this.lblPlazoMeses.Text = "Plazo (meses):";
            // 
            // txtPlazoMeses
            // 
            this.txtPlazoMeses.Location = new System.Drawing.Point(100, 72);
            this.txtPlazoMeses.Name = "txtPlazoMeses";
            this.txtPlazoMeses.Size = new System.Drawing.Size(200, 20);
            this.txtPlazoMeses.TabIndex = 5;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 105);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(74, 13);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(100, 102);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // chkPagado
            // 
            this.chkPagado.AutoSize = true;
            this.chkPagado.Location = new System.Drawing.Point(15, 135);
            this.chkPagado.Name = "chkPagado";
            this.chkPagado.Size = new System.Drawing.Size(62, 17);
            this.chkPagado.TabIndex = 8;
            this.chkPagado.Text = "Pagado";
            this.chkPagado.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(100, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CreditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 211);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkPagado);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtPlazoMeses);
            this.Controls.Add(this.lblPlazoMeses);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.lblTasaInteres);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Name = "CreditoForm";
            this.Text = "Crear Crédito";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblTasaInteres;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label lblPlazoMeses;
        private System.Windows.Forms.TextBox txtPlazoMeses;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.CheckBox chkPagado;
        private System.Windows.Forms.Button btnGuardar;
    }
}