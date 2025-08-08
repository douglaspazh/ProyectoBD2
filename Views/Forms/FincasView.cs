using ProyectoBD2.Data;
using System.Data;

namespace ProyectoBD2.Views.Forms
{
    public partial class FincasView : Form
    {
        // Fields
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;
        private bool isEditing;
        private string message = string.Empty;
        private readonly Utils utils = new();

        // Constructor
        public FincasView()
        {
            InitializeComponent();

            SetListBindingSource();
            SetComboBoxData();

            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Remove( tbpDetalleLote );
        }

        public void SetListBindingSource( string spName = "spGetAllFincas", Dictionary<string, dynamic>? parameters = null )
        {
            parameters ??= new()
            {
                { "@PageNumber", _actualPage },
                { "@PageSize", _pageSize }
            };
            dgvFincas.DataSource = utils.ExecuteSPDataTable( spName, parameters );

            _totalRecords = dgvFincas.Rows.Count;
            _totalPages = (int)Math.Ceiling( (double)_totalRecords / _pageSize );
            DisplayPageInfo();

            if ( dgvFincas.Columns.Contains( "FincaID" ) )
                dgvFincas.Columns["FincaID"].Visible = false;
            if ( dgvFincas.Columns.Contains( "ProductorID" ) )
                dgvFincas.Columns["ProductorID"].Visible = false;

        }

        public void SetComboBoxData()
        {
            // Load data for Departamentos combo box
            var departamentos = utils.ExecuteViewDataTable( "vGetDepartamentos" );
            cmbDepartamento.DataSource = departamentos;
            cmbDepartamento.DisplayMember = "Nombre";
            cmbDepartamento.ValueMember = "DepartamentoID";

            // Load data for Productores combo box
            var productores = utils.ExecuteViewDataTable( "vGetProductores" );
            cmbProductor.DataSource = productores;
            cmbProductor.DisplayMember = "NombreCompleto";
            cmbProductor.ValueMember = "ProductorID";
        }

        public void SetMunicipiosComboBox( int departamentoID )
        {
            // Load municipios based on selected departamento
            Dictionary<string, dynamic> parameters = new()
            {
                { "@DepartamentoID", departamentoID }
            };
            cmbMunicipio.DataSource = utils.ExecuteSPDataTable( "spGetMunicipios", parameters );
            cmbMunicipio.DisplayMember = "Nombre";
            cmbMunicipio.ValueMember = "MunicipioID";
        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} fincas";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }

        public void ClearFields()
        {
            txtFincaID.Clear();
            txtProductorID.Clear();
            txtNombre.Clear();
            cmbProductor.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            cmbMunicipio.SelectedIndex = -1;
            txtUbicacion.Clear();
            txtExtensionTotal.Clear();
        }

        private void btnBuscar_Click( object sender, EventArgs e )
        {
            bool emptySearch = string.IsNullOrWhiteSpace( txtBuscar.Text.Trim() );
            if ( !emptySearch )
            {
                Dictionary<string, dynamic> parameters = new()
                {
                    { "@Value", txtBuscar.Text.Trim() },
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
                SetListBindingSource( "spGetFincasByValue", parameters );
            }
            else
            {
                SetListBindingSource();
            }
        }

        private void btnNuevoLote_Click( object sender, EventArgs e )
        {
            tabControl.TabPages.Remove( tbpLista );
            tabControl.TabPages.Add( tbpDetalleLote );
            tabControl.SelectedTab = tbpDetalleLote;
            tbpDetalleLote.Text = "Nuevo Lote";
        }

        private void btnAgregar_Click( object sender, EventArgs e )
        {
            isEditing = false;

            lblFincaID.Visible = false;
            txtFincaID.Visible = false;
            lblProductorID.Visible = false;
            txtProductorID.Visible = false;
            btnGuardar.Text = "Guardar";

            tabControl.TabPages.Remove( tbpLista );
            tabControl.TabPages.Add( tbpDetalle );
            tabControl.SelectedTab = tbpDetalle;
            tbpDetalle.Text = "Nueva Finca";
        }

        private void btnEditar_Click( object sender, EventArgs e )
        {
            var selectedRow = dgvFincas.CurrentRow.DataBoundItem as DataRowView;
            if ( selectedRow != null )
            {
                isEditing = true;
                lblFincaID.Visible = true;
                txtFincaID.Visible = true;
                lblProductorID.Visible = true;
                txtProductorID.Visible = true;
                btnGuardar.Text = "Actualizar";

                tabControl.TabPages.Remove( tbpLista );
                tabControl.TabPages.Add( tbpDetalle );
                tabControl.SelectedTab = tbpDetalle;
                tbpDetalle.Text = "Editar Finca";

                Dictionary<string, dynamic> parameters = new()
                {
                    { "@ID", Convert.ToInt32( selectedRow["FincaID"] ) }
                };
                DataTable fincaData = utils.ExecuteSPDataTable( "spGetFincaByID", parameters );
                if ( fincaData.Rows.Count > 0 )
                {
                    DataRow row = fincaData.Rows[0];

                    SetMunicipiosComboBox( Convert.ToInt32( row["DepartamentoID"] ) );

                    // Populate fields with data from the selected finca
                    txtFincaID.Text = row["FincaID"].ToString();
                    txtProductorID.Text = row["ProductorID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString();
                    cmbProductor.SelectedValue = Convert.ToInt32( row["ProductorID"] );
                    cmbDepartamento.SelectedValue = Convert.ToInt32( row["DepartamentoID"] );
                    cmbMunicipio.SelectedValue = Convert.ToInt32( row["MunicipioID"] );
                    txtUbicacion.Text = row["Ubicacion"].ToString();
                    txtExtensionTotal.Text = row["ExtencionTotal"].ToString();
                }
            }
        }

        private void btnEliminar_Click( object sender, EventArgs e )
        {
            var selectedRow = dgvFincas.CurrentRow.DataBoundItem as DataRowView;
            if ( selectedRow != null )
            {
                var result = MessageBox.Show( "Esta seguro de eliminar este productor?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if ( result == DialogResult.Yes )
                {
                    Dictionary<string, dynamic> parameters = new()
                    {
                        { "@ID", Convert.ToInt32( selectedRow["FincaID"] ) }
                    };
                    utils.ExecuteSPDataTable( "spDeleteFinca", parameters );
                    MessageBox.Show( "Finca eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    SetListBindingSource();
                }
            }
            else
            {
                MessageBox.Show( "No se ha seleccionado ninguna finca para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void cmbDepartamento_SelectedIndexChanged( object sender, EventArgs e )
        {
            if ( cmbDepartamento.SelectedValue == null )
                return;

            SetMunicipiosComboBox( Convert.ToInt32( cmbDepartamento.SelectedValue ) );
        }

        private void btnAnterior_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", --_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource( "spGetAllFincas", parameters );
        }

        private void btnSiguiente_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", ++_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource( "spGetAllFincas", parameters );
        }

        private void txtBuscar_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
            {
                btnBuscar.PerformClick();
                e.SuppressKeyPress = true; // Prevents the beep sound
            }
        }

        private void btnGuardar_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@ProductorID", cmbProductor.SelectedValue },
                { "@Nombre", txtNombre.Text.Trim() },
                { "@MunicipioID", cmbMunicipio.SelectedValue },
                { "@Ubicacion", txtUbicacion.Text.Trim() },
                { "@ExtencionTotal", Convert.ToDecimal( txtExtensionTotal.Text ) }
            };
            if ( isEditing )
            {
                parameters.Add( "@ID", Convert.ToInt32( txtFincaID.Text ) );

                utils.ExecuteSPDataTable( "spUpdateFinca", parameters );
                message = "Finca actualizada correctamente.";
            }
            else
            {
                utils.ExecuteSPDataTable( "spInsertFinca", parameters );
                message = "Finca creada correctamente.";
            }

            SetListBindingSource();
            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Add( tbpLista );
            tabControl.SelectedTab = tbpLista;
            ClearFields();
            
            MessageBox.Show( message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void btnCancelar_Click( object sender, EventArgs e )
        {
            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Add( tbpLista );
            tabControl.SelectedTab = tbpLista;
            ClearFields();
        }

        private void btnCerrar_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
