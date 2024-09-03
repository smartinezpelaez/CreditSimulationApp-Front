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
    public partial class ClienteForm : Form
    {
        private readonly ClienteDTO _cliente;
        private readonly bool _esEdicion;

        public ClienteForm(ClienteDTO cliente = null)
        {
            InitializeComponent();
            _esEdicion = cliente != null;
            _cliente = cliente ?? new ClienteDTO();
            LoadClienteData();
        }

        private void LoadClienteData()
        {
            if (_esEdicion)
            {
                txtNombre.Text = _cliente.Nombre;
                txtEmail.Text = _cliente.Email;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            _cliente.Nombre = txtNombre.Text;
            _cliente.Email = txtEmail.Text;

            var apiService = new ApiService();

            if (_esEdicion)
            {
                // Aquí puedes implementar la lógica de actualización si es necesario.
                MessageBox.Show("Función de edición aún no implementada.");
            }
            else
            {
                var nuevoCliente = await apiService.CreateClienteAsync(_cliente);
                if (nuevoCliente != null)
                {
                    MessageBox.Show("Cliente creado con éxito.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al crear el cliente.");
                }
            }
        }
    }

}
