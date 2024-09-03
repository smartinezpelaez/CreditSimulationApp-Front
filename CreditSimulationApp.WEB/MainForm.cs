using CreditSimulationApp.DAL.DTOs;

namespace CreditSimulationApp.WEB
{
    public partial class MainForm : Form
    {
        private readonly ApiService _apiService;

        public MainForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
            LoadClientesAsync();
        }

        private async void LoadClientesAsync()
        {
            var clientes = await _apiService.GetClientesAsync();
            dgvCliente.DataSource = clientes;
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                var cliente = (ClienteDTO)dgvCliente.SelectedRows[0].DataBoundItem;
                var detalleForm = new ClienteDetailForm(cliente);
                detalleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente.");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var clienteForm = new ClienteForm();
            if (clienteForm.ShowDialog() == DialogResult.OK)
            {
                LoadClientesAsync(); // Recargar la lista de clientes después de agregar
            }
        }

        private async void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                var cliente = (ClienteDTO)dgvCliente.SelectedRows[0].DataBoundItem;
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var result = await _apiService.DeleteClienteAsync(cliente.Id);
                    if (result)
                    {
                        LoadClientesAsync(); // Recargar la lista de clientes después de eliminar
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente.");
            }
        }

        private void BtnCrearCredito_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                var cliente = (ClienteDTO)dgvCliente.SelectedRows[0].DataBoundItem;
                CreditoForm creditoForm = new CreditoForm(cliente.Id);
                creditoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para crear un crédito.");
            }
        }
    }
}
