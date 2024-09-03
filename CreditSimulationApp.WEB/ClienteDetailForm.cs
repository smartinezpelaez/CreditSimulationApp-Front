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
    public partial class ClienteDetailForm : Form
    {
        private readonly ClienteDTO _cliente;

        public ClienteDetailForm(ClienteDTO cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            LoadClienteDetails();
        }

        private async void LoadClienteDetails()
        {
            lblNombre.Text = _cliente.Nombre;
            lblEmail.Text = _cliente.Email;

            var apiService = new ApiService();
            var creditos = await apiService.GetCreditosAsync();
            var creditosCliente = creditos.Where(c => c.ClienteId == _cliente.Id).ToList();
            dgvCreditos.DataSource = creditosCliente; // Asumiendo que tienes un DataGridView llamado dgvCreditos
        }
    }

}
