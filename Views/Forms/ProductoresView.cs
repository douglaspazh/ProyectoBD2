using ProyectoBD2.Data;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoBD2.Views.Forms
{
    public partial class ProductoresView : Form
    {
        // Fields
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;
        private bool isEditing;
        private readonly Utils utils = new();

        // Constructor
        public ProductoresView()
        {
            InitializeComponent();

            SetListBindingSource( "spGetAllProductores" );
            CargarEstados();

            tabControl.TabPages.Remove( tbpDetalleProductor );

            cmbRecordsPerPage.SelectedIndex = 0;
            cmbEstado.SelectedIndex = -1;
        }

        public void SetListBindingSource( string spName = "spGetAllProductores", Dictionary<string, dynamic>? parameters = null )
        {
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvProductores.DataSource = utils.ExecuteSPDataTable( spName, parameters );

            _totalRecords = dgvProductores.Rows.Count;
            _totalPages = (int)Math.Ceiling( (double)_totalRecords / _pageSize );
            DisplayPageInfo();

            if ( dgvProductores.Columns.Contains( "ProductorID" ) )
                dgvProductores.Columns["ProductorID"].Visible = false;
            if ( dgvProductores.Columns.Contains( "EstadoID" ) )
                dgvProductores.Columns["EstadoID"].Visible = false;
        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} productores";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }

        public void CargarEstados()
        {
            var estados = utils.ExecuteViewDataTable( "vGetProductorEstados" );

            cmbEstado.DataSource ??= estados.AsEnumerable().Select( row => new
            {
                Nombre = row["Nombre"],
                EstadoID = row["EstadoID"]
            } ).ToList();

            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "EstadoID";
        }

        public void ClearFields()
        {
            txtProductorID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDocumento.Clear();
            txtRTN.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private void btnBuscar_Click( object sender, EventArgs e )
        {
            bool emptySearch = string.IsNullOrWhiteSpace( txtBuscar.Text );
            if ( !emptySearch )
            {
                Dictionary<string, dynamic> parameters = new()
                {
                    { "@Value", txtBuscar.Text.Trim() },
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
                SetListBindingSource( "spGetProductorByValue", parameters );
            }
            else
            {
                SetListBindingSource();
            }
        }

        private void btnAgregar_Click( object sender, EventArgs e )
        {
            isEditing = false;
            lblProductorID.Visible = false;
            txtProductorID.Visible = false;
            btnGuardar.Text = "Guardar";

            tabControl.TabPages.Remove( tbpLista );
            tabControl.TabPages.Add( tbpDetalleProductor );
            tabControl.SelectedTab = tbpDetalleProductor;
            tbpDetalleProductor.Text = "Nuevo Productor";
        }

        private void btnEditar_Click( object sender, EventArgs e )
        {
            var selectedRow = dgvProductores.CurrentRow.DataBoundItem as DataRowView;
            if ( selectedRow != null )
            {
                isEditing = true;
                lblProductorID.Visible = true;
                txtProductorID.Visible = true;

                tabControl.TabPages.Remove( tbpLista );
                tabControl.TabPages.Add( tbpDetalleProductor );
                tabControl.SelectedTab = tbpDetalleProductor;
                tbpDetalleProductor.Text = "Editar Productor";
                btnGuardar.Text = "Actualizar";

                Dictionary<string, dynamic> parameters = new()
                {
                    { "@ID", Convert.ToInt32( selectedRow["ProductorID"] ) }
                };
                var productorData = utils.ExecuteSPDataTable( "spGetProductorByID", parameters );

                if ( productorData.Rows.Count > 0 ) // Ensure there is at least one row in the DataTable
                {
                    DataRow row = productorData.Rows[0]; // Access the first row of the DataTable
                    txtProductorID.Text = row["ProductorID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString() ?? string.Empty;
                    txtApellido.Text = row["Apellido"].ToString() ?? string.Empty;
                    txtTelefono.Text = row["Telefono"].ToString() ?? string.Empty;
                    txtEmail.Text = row["Correo"].ToString() ?? string.Empty;
                    txtDocumento.Text = row["Documento"].ToString() ?? string.Empty;
                    txtRTN.Text = row["RTN"].ToString() ?? string.Empty;
                    cmbEstado.SelectedValue = Convert.ToInt32( row["EstadoID"] );
                }
            }
        }

        private void btnEliminar_Click( object sender, EventArgs e )
        {
            var selectedRow = dgvProductores.CurrentRow?.DataBoundItem as DataRowView;

            if ( selectedRow != null )
            {
                var result = MessageBox.Show( "Esta seguro de eliminar este productor?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if ( result == DialogResult.Yes )
                {
                    Dictionary<string, dynamic> parameters = new()
                    {
                        { "@ID", Convert.ToInt32( selectedRow["ProductorID"] ) }
                    };
                    utils.ExecuteSPDataTable( "spDeleteProductor", parameters );
                    SetListBindingSource();
                    MessageBox.Show( "Productor eliminado exitosamente." );
                }
            }
            else
            {
                // If no productor is selected, show a message
                MessageBox.Show( "No se ha seleccionado ningún productor." );
            }
        }

        private void btnGuardar_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> productor = new()
            {
                { "@Nombre", txtNombre.Text.Trim() },
                { "@Apellido", txtApellido.Text.Trim() },
                { "@Telefono", txtTelefono.Text.Trim() },
                { "@Correo", txtEmail.Text.Trim() },
                { "@Documento", txtDocumento.Text.Trim() },
                { "@RTN", txtRTN.Text.Trim() },

            };

            var result = new DataTable();
            if ( isEditing )
            {
                productor.Add( "@ID", Convert.ToInt32( txtProductorID.Text.Trim() ) );
                productor.Add( "@Estado", Convert.ToInt32( cmbEstado.SelectedValue ) );

                result = utils.ExecuteSPDataTable( "spUpdateProductor", productor );
            }
            else
            {
                result = utils.ExecuteSPDataTable( "spInsertProductor", productor );
            }


            if ( (int)result.Rows[0]["Estado"] == 10000 )
            {
                SetListBindingSource();
                tabControl.TabPages.Remove( tbpDetalleProductor );
                tabControl.TabPages.Add( tbpLista );
                tabControl.SelectedTab = tbpLista;
                ClearFields();
            }

            MessageBox.Show( result.Rows[0]["Mensaje"].ToString() );
        }

        private void btnEliminar2_Click( object sender, EventArgs e )
        {
            btnEliminar.PerformClick();
        }

        private void btnCancelar_Click( object sender, EventArgs e )
        {
            tabControl.TabPages.Remove( tbpDetalleProductor );
            tabControl.TabPages.Add( tbpLista );
            tabControl.SelectedTab = tbpLista;
            ClearFields();
        }

        private void btnAnterior_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", --_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource( "spGetAllProductores", parameters );
        }

        private void btnSiguiente_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", ++_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource( "spGetAllProductores", parameters );
        }

        private void btnCerrar_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void txtBuscar_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                btnBuscar.PerformClick();
                e.SuppressKeyPress = true; // Prevents the beep sound
            }
        }
    }
}
