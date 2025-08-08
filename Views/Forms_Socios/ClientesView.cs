using ProyectoBD2.Data;
using ProyectoBD2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD2.Views.Forms
{
    public partial class ClientesView : Form
    {
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;
        private bool isEditing;
        private readonly Utils utils = new();

        public ClientesView()
        {

            InitializeComponent();

            SetListBindingSource("spObtenerClientes");

            tabControl1.TabPages.Remove(tbpDetallesCliente);

            cmbRecordsPerPage.SelectedIndex = 0;
        }

        public void SetListBindingSource(string spName = "spObtenerClientes", Dictionary<string, dynamic>? parameters = null)
        {
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvClientes.DataSource = utils.ExecuteSPDataTable(spName, parameters);

            _totalRecords = dgvClientes.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            DisplayPageInfo();

            if (dgvClientes.Columns.Contains("ProductorID"))
                dgvClientes.Columns["ProductorID"].Visible = false;
        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} clientes";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvClientes.CurrentRow.DataBoundItem as DataRowView;
            if (selectedRow != null)
            {
                isEditing = true;
                lblClienteID.Visible = true;
                txtClienteID.Visible = true;

                tabControl1.TabPages.Remove(tbpLista);
                tabControl1.TabPages.Add(tbpDetallesCliente);
                tabControl1.SelectedTab = tbpDetallesCliente;
                tbpDetallesCliente.Text = "Editar Clientes";
                btnGuardar.Text = "Actualizar";

                Dictionary<string, dynamic> parameters = new()
                {
                    { "@ID", Convert.ToInt32( selectedRow["ClienteID"] ) }
                };
                var productorData = utils.ExecuteSPDataTable("spObtenerClientesConID", parameters);

                if (productorData.Rows.Count > 0) // Ensure there is at least one row in the DataTable
                {
                    DataRow row = productorData.Rows[0]; // Access the first row of the DataTable
                    txtClienteID.Text = row["ClienteID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString() ?? string.Empty;
                    txtApellido.Text = row["Apellido"].ToString() ?? string.Empty;
                    txtTelefono.Text = row["Telefono"].ToString() ?? string.Empty;
                    txtEmail.Text = row["Correo"].ToString() ?? string.Empty;
                    txtDireccion.Text = row["Direccion"].ToString() ?? string.Empty;
                    txtDocumento.Text = row["Documento"].ToString() ?? string.Empty;
                    txtRTN.Text = row["RTN"].ToString() ?? string.Empty;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool emptySearch = string.IsNullOrWhiteSpace(txtBuscar.Text);
            if (!emptySearch)
            {
                Dictionary<string, dynamic> parameters = new()
                {
                    { "@Value", txtBuscar.Text.Trim() },
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
                SetListBindingSource("spGetProductorByValue", parameters);
            }
            else
            {
                SetListBindingSource();
            }
        }
        public void ClearFields()
        {
            txtClienteID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtRTN.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            isEditing = false;
            lblClienteID.Visible = false;
            txtClienteID.Visible = false;
            btnGuardar.Text = "Guardar";

            tabControl1.TabPages.Remove(tbpLista);
            tabControl1.TabPages.Add(tbpDetallesCliente);
            tabControl1.SelectedTab = tbpDetallesCliente;
            tbpDetallesCliente.Text = "Nuevo Productor";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> cliente = new()
            {
                { "@Nombre", txtNombre.Text.Trim() },
                { "@Apellido", txtApellido.Text.Trim() },
                { "@Telefono", txtTelefono.Text.Trim() },
                { "@Correo", txtEmail.Text.Trim() },
                { "@Documento", txtDocumento.Text.Trim() },
                { "@Direccion", txtDireccion.Text.Trim() },
                { "@RTN", txtRTN.Text },

            };

            var result = new DataTable();
            if (isEditing)
            {
                cliente.Add("@ID", Convert.ToInt32(txtClienteID.Text.Trim()));
                result = utils.ExecuteSPDataTable("spModificarCliente", cliente);
            }
            else
            {
                result = utils.ExecuteSPDataTable("spCrearCliente", cliente);
            }


            if ((int)result.Rows[0]["Estado"] == 10000)
            {
                SetListBindingSource();
                tabControl1.TabPages.Remove(tbpDetallesCliente);
                tabControl1.TabPages.Add(tbpLista);
                tabControl1.SelectedTab = tbpLista;
                ClearFields();
            }

            MessageBox.Show(result.Rows[0]["Mensaje"].ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tbpDetallesCliente);
            tabControl1.TabPages.Add(tbpLista);
            tabControl1.SelectedTab = tbpLista;
            ClearFields();
        }
    }
}
