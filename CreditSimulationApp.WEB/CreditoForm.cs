using CreditSimulationApp.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditSimulationApp.WEB
{
    public partial class CreditoForm : Form
    {
        private readonly ApiService _apiService;
        private int _clienteId;

        public CreditoForm(int clienteId)
        {
            InitializeComponent();
            _apiService = new ApiService();
            _clienteId = clienteId;
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                double monto = Convert.ToDouble(txtMonto.Text);
                double tasaInteres = Convert.ToDouble(txtTasaInteres.Text);
                int plazoMeses = Convert.ToInt32(txtPlazoMeses.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                bool pagado = chkPagado.Checked;

                // Crear un objeto CreditoDTO
                CreditoDTO nuevoCredito = new CreditoDTO
                {
                    Monto = (decimal)monto,
                    TasaInteres = (decimal)tasaInteres,
                    PlazoMeses = plazoMeses,
                    FechaInicio = fechaInicio,
                    Pagado = pagado,
                    ClienteId = _clienteId
                };

                // Llamar a la API para guardar el crédito
                CreditoDTO creditoCreado = await _apiService.CreateCreditoAsync(nuevoCredito);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Crédito guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Ocurrió un error al guardar el crédito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
