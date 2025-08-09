using ProyectoBD2.Data;
using System.Data;
using System.Diagnostics;

namespace ProyectoBD2.Views.Forms
{
    public partial class FincasView : Form
    {
        // Fields
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;

        private int _actualPageLotes = 1;
        private int _pageSizeLotes = 25;
        private int _totalPagesLotes = 0;
        private int _totalRecordsLotes = 0;

        private bool isEditing;
        private string message = string.Empty;
        private readonly Utils utils = new();

        // Constructor
        public FincasView()
        {
            InitializeComponent();

            SetListFincasSource();
            SetListLotesSource();
            SetComboBoxData();
            SetMunicipiosComboBox( 0 );

            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Remove( tbpDetalleLote );
        }

        public void SetListFincasSource( string spName = "spGetAllFincas", Dictionary<string, dynamic>? parameters = null )
        {
            parameters ??= new()
            {
                { "@PageNumber", _actualPage },
                { "@PageSize", _pageSize }
            };

            var data = utils.ExecuteSPDataTable( spName, parameters );
            dgvFincas.DataSource = data;

            _totalRecords = data.Rows.Count;
            _totalPages = (int)Math.Ceiling( (double)_totalRecords / _pageSize );
            DisplayPageInfo();

            if ( dgvFincas.Columns.Contains( "FincaID" ) )
                dgvFincas.Columns["FincaID"].Visible = false;
            if ( dgvFincas.Columns.Contains( "ProductorID" ) )
                dgvFincas.Columns["ProductorID"].Visible = false;
        }

        public void SetListLotesSource( string spName = "spGetAllLotes", Dictionary<string, dynamic>? parameters = null )
        {
            parameters ??= new()
            {
                { "@PageNumber", _actualPageLotes },
                { "@PageSize", _pageSizeLotes }
            };
            var data = utils.ExecuteSPDataTable( spName, parameters );
            dgvLotes.DataSource = data;

            _totalRecordsLotes = data.Rows.Count;
            _totalPagesLotes = (int)Math.Ceiling( (double)_totalRecordsLotes / _pageSizeLotes );
            DisplayPageInfo();

            //if (dgvLotes.Columns.Contains("LoteID"))
            //    dgvLotes.Columns["LoteID"].Visible = false;
            //if (dgvLotes.Columns.Contains("FincaID") )
            //    dgvLotes.Columns["FincaID"].Visible = false;
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

            // Load data for Fincas combo box
            var fincas = utils.ExecuteViewDataTable( "vGetFincas" );
            cmbFincas.DataSource = fincas;
            cmbFincas.DisplayMember = "Nombre";
            cmbFincas.ValueMember = "FincaID";
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

            lblTotalRegistrosLotes.Text = $"Total: {_totalRecordsLotes} lotes";
            lblLotesPages.Text = $"Página {_actualPageLotes} de {_totalPagesLotes}";
            lblLotesPerPage.Text = $"Mostrando {_pageSizeLotes} registros por página";
            btnSiguiente2.Enabled = _actualPageLotes < _totalPagesLotes;
            btnAnterior2.Enabled = _actualPageLotes > 1;
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

            txtFincaID_Lote.Clear();
            txtLoteID.Clear();
            txtExtencion.Clear();
            txtTipoRiego.Clear();
            txtTipoSuelo.Clear();
            cmbFincas.SelectedIndex = -1;
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
                SetListFincasSource( "spGetFincasByValue", parameters );
            }
            else
            {
                SetListFincasSource( "spGetAllFincas" );
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

            cmbDepartamento.SelectedIndex = -1;
            cmbProductor.SelectedIndex = -1;

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
                    SetListFincasSource();
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

            if ( cmbDepartamento.SelectedValue is int departamentoID && departamentoID > 0 )
            {
                SetMunicipiosComboBox( departamentoID );
            }
        }

        private void btnAnterior_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", --_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListFincasSource( "spGetAllFincas", parameters );
        }

        private void btnSiguiente_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", ++_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListFincasSource( "spGetAllFincas", parameters );
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
                { "@ProductorID", cmbProductor.SelectedValue! },
                { "@Nombre", txtNombre.Text.Trim() },
                { "@MunicipioID", cmbMunicipio.SelectedValue! },
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

            SetListFincasSource();
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

        private void btnBuscarLote_Click( object sender, EventArgs e )
        {
            bool emptySearch = string.IsNullOrWhiteSpace( txtBuscarLote.Text.Trim() );
            if ( !emptySearch )
            {
                Dictionary<string, dynamic> parameters = new()
                {
                    { "@Value", txtBuscarLote.Text.Trim() },
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
                SetListFincasSource( "spGetLotesByValue", parameters );
            }
            else
            {
                SetListFincasSource( "spGetAllLotes" );
            }
        }

        private void btnAgregarLote_Click( object sender, EventArgs e )
        {
            isEditing = false;
            lblLoteID.Visible = false;
            txtLoteID.Visible = false;
            lblFincaID_Lote.Visible = false;
            txtFincaID_Lote.Visible = false;
            btnGuardarLote.Text = "Guardar";
            tabControl.TabPages.Remove( tbpListaLotes );
            tabControl.TabPages.Add( tbpDetalleLote );
            tabControl.SelectedTab = tbpDetalleLote;
            tbpDetalleLote.Text = "Nuevo Lote";
            cmbFincas.SelectedIndex = -1;
        }

        private void btnEditarLote_Click( object sender, EventArgs e )
        {
            var selectedRow = dgvLotes.CurrentRow.DataBoundItem as DataRowView;
            if ( selectedRow != null )
            {
                isEditing = true;
                lblLoteID.Visible = true;
                txtLoteID.Visible = true;
                lblFincaID_Lote.Visible = true;
                txtFincaID_Lote.Visible = true;

                btnGuardarLote.Text = "Actualizar";
                tabControl.TabPages.Remove( tbpLista );
                tabControl.TabPages.Add( tbpDetalleLote );
                tabControl.SelectedTab = tbpDetalleLote;
                tbpDetalleLote.Text = "Editar Lote";
                Dictionary<string, dynamic> parameters = new()
                {
                    { "@ID", Convert.ToInt32( selectedRow["LoteID"] ) }
                };
                DataTable loteData = utils.ExecuteSPDataTable( "spGetLoteByID", parameters );
                if ( loteData.Rows.Count > 0 )
                {
                    DataRow row = loteData.Rows[0];
                    // Populate fields with data from the selected lote
                    txtLoteID.Text = row["LoteID"].ToString();
                    cmbFincas.SelectedValue = Convert.ToInt32( row["FincaID"] );
                    txtExtencion.Text = row["Extencion"].ToString();
                    txtTipoRiego.Text = row["TipoDeRiego"].ToString();
                    txtTipoSuelo.Text = row["TipoSuelo"].ToString();
                }
            }
        }

        private void btnGuardarLote_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@FincaID", cmbFincas.SelectedValue! },
                { "@Extencion", Convert.ToDecimal( txtExtencion.Text ) },
                { "@TipoDeRiego", txtTipoRiego.Text.Trim() },
                { "@TipoSuelo", txtTipoSuelo.Text.Trim() }
            };

            if ( isEditing )
            {
                parameters.Add( "@ID", Convert.ToInt32( txtLoteID.Text ) );
                utils.ExecuteSPDataTable( "spUpdateLote", parameters );
                message = "Lote actualizado correctamente.";
            }
            else
            {
                utils.ExecuteSPDataTable( "spInsertLote", parameters );
                message = "Lote creado correctamente.";
            }

            SetListLotesSource();
            tabControl.TabPages.Remove( tbpDetalleLote );
            tabControl.TabPages.Add( tbpListaLotes );
            tabControl.SelectedTab = tbpListaLotes;
            ClearFields();

            MessageBox.Show( message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void btnCancelar2_Click( object sender, EventArgs e )
        {
            tabControl.TabPages.Remove( tbpDetalleLote );
            tabControl.TabPages.Add( tbpListaLotes );
            tabControl.SelectedTab = tbpListaLotes;
            ClearFields();
        }

        private void btnAnterior2_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", --_actualPageLotes },
                { "@PageSize", _pageSizeLotes }
            };
            SetListLotesSource( "spGetAllLotes", parameters );
        }

        private void btnSiguiente2_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", ++_actualPageLotes },
                { "@PageSize", _pageSizeLotes }
            };
            SetListLotesSource( "spGetAllLotes", parameters );
        }
    }
}
