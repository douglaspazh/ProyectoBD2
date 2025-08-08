using ProyectoBD2.Data;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoBD2.Views.Forms
{
    public partial class ProveedoresView : Form
    {
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;
        private bool isEditing;
        private readonly Utils utils = new();

        public ProveedoresView()
        {
            InitializeComponent();
            SetListBindingSource("spGetAllProveedores");
            CargarEstados();

            tabControl1.TabPages.Remove(tbpDetalleProveedores);

            cmbRecordsPerPage.SelectedIndex = 0;
            cmbEstado.SelectedIndex = -1;
        }

        public void SetListBindingSource(string spName = "spGetAllProveedores", Dictionary<string, dynamic>? parameters = null)
        {
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvProveedores.DataSource = utils.ExecuteSPDataTable(spName, parameters);

            _totalRecords = dgvProveedores.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            DisplayPageInfo();

            if (dgvProveedores.Columns.Contains("ProveedorID"))
                dgvProveedores.Columns["ProveedorID"].Visible = false;
            if (dgvProveedores.Columns.Contains("EstadoID"))
                dgvProveedores.Columns["EstadoID"].Visible = false;
        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} proveedores";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }

        public void CargarEstados()
        {
            var estados = utils.ExecuteViewDataTable("vGetProveedoresEstados");

            cmbEstado.DataSource ??= estados.AsEnumerable().Select(row => new
            {
                Nombre = row["Nombre"],
                EstadoID = row["EstadoID"]
            }).ToList();

            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "EstadoID";
        }

        public void ClearFields()
        {
            txtProveedorID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDocumento.Clear();
            txtRTN.Clear();
            txtperiododepago.Clear();
            txtTasadeinteres.Clear();
            cmbDireccion.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            isEditing = false;
            lblProveedorID.Visible = false;
            txtProveedorID.Visible = false;
            btnGuardar.Text = "Guardar";

            tabControl1.TabPages.Remove(tabListaProveedores);
            tabControl1.TabPages.Add(tbpDetalleProveedores);
            tabControl1.SelectedTab = tbpDetalleProveedores;
            tbpDetalleProveedores.Text = "Nuevo Productor";
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

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
                SetListBindingSource("spGetProveedorByValue", parameters);
            }
            else
            {
                SetListBindingSource();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvProveedores.CurrentRow.DataBoundItem as DataRowView;
            if (selectedRow != null)
            {
                isEditing = true;
                lblProveedorID.Visible = true;
                txtProveedorID.Visible = true;

                tabControl1.TabPages.Remove(tabListaProveedores);
                tabControl1.TabPages.Add(tbpDetalleProveedores);
                tabControl1.SelectedTab = tbpDetalleProveedores;
                tbpDetalleProveedores.Text = "Editar Proveedor";
                btnGuardar.Text = "Actualizar";

                Dictionary<string, dynamic> parameters = new()
                {
                    { "@ID", Convert.ToInt32( selectedRow["ProveedorID"] ) }
                };
                var proveedorData = utils.ExecuteSPDataTable("spGetProveedorByID", parameters);

                if (proveedorData.Rows.Count > 0)
                {
                    DataRow row = proveedorData.Rows[0];
                    txtProveedorID.Text = row["ProveedorID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString() ?? string.Empty;
                    txtApellido.Text = row["Apellido"].ToString() ?? string.Empty;
                    txtTelefono.Text = row["Telefono"].ToString() ?? string.Empty;
                    txtEmail.Text = row["Correo"].ToString() ?? string.Empty;
                    txtDocumento.Text = row["Documento"].ToString() ?? string.Empty;
                    txtTasadeinteres.Text = row["Tasa de interes"].ToString() ?? string.Empty;
                    txtRTN.Text = row["RTN"].ToString() ?? string.Empty;
                    cmbEstado.SelectedValue = Convert.ToInt32(row["EstadoID"]);
                    cmbDireccion.SelectedValue = Convert.ToInt32(row["Direccion"]);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvProveedores.CurrentRow?.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                var result = MessageBox.Show("Esta seguro de eliminar este proveedor?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Dictionary<string, dynamic> parameters = new()
                    {
                        { "@ID", Convert.ToInt32( selectedRow["ProveedorID"] ) }
                    };
                    utils.ExecuteSPDataTable("spDeleteProveedor", parameters);
                    SetListBindingSource();
                    MessageBox.Show("Proveedor eliminado exitosamente.");
                }
            }
            else
            {
                // If no productor is selected, show a message
                MessageBox.Show("No se ha seleccionado ningún proveedor.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cmbDireccion.SelectedValue == null)
            {
                MessageBox.Show("Por favor selecciona una dirección.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dictionary<string, dynamic> productor = new()
            {
                { "@Nombre", txtNombre.Text.Trim() },
                { "@Apellido", txtApellido.Text.Trim() },
                { "@Telefono", txtTelefono.Text.Trim() },
                { "@Correo", txtEmail.Text.Trim() },
                { "@Documento", txtDocumento.Text.Trim() },
                { "@RTN", txtRTN.Text.Trim() },
                { "Tasa de Interes" , txtTasadeinteres.Text.Trim() },
                { "Periodo de Pago Dias" , txtperiododepago.Text.Trim() },
                { "@Direccion", cmbDireccion.SelectedValue },

            };

            var result = new DataTable();
            if (isEditing)
            {
                productor.Add("@ID", Convert.ToInt32(txtProveedorID.Text.Trim()));
                productor.Add("@Estado", Convert.ToInt32(cmbEstado.SelectedValue));

                result = utils.ExecuteSPDataTable("spUpdateProveedor", productor);
            }
            else
            {
                result = utils.ExecuteSPDataTable("spInsertProveedor", productor);
            }


            if ((int)result.Rows[0]["Estado"] == 10000)
            {
                SetListBindingSource();
                tabControl1.TabPages.Remove(tbpDetalleProveedores);
                tabControl1.TabPages.Add(tabListaProveedores);
                tabControl1.SelectedTab = tabListaProveedores;
                ClearFields();
            }

            MessageBox.Show(result.Rows[0]["Mensaje"].ToString());
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            btnEliminar.PerformClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tbpDetalleProveedores);
            tabControl1.TabPages.Add(tabListaProveedores);
            tabControl1.SelectedTab = tabListaProveedores;
            ClearFields();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", --_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource("spGetAllProveedores", parameters);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", ++_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource("spGetAllProveedores", parameters);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}


