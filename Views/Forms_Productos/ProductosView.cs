using ProyectoBD2.Data;
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
    public partial class ProductosView : Form
    {
        // Fields
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;
        private bool isEditing;
        private readonly Utils utils = new();
        public ProductosView()
        {
            InitializeComponent();

            SetListBindingSource();
            SetComboBoxData();

            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Remove( tbpNuevaCategoria );
            cmbRecordsPerPage.SelectedIndex = 0;
            cmbCategorias.SelectedIndex = -1;

        }

        public void SetListBindingSource( string spName = "spGetAllProductos", Dictionary<string, dynamic>? parameters = null )
        {
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvProductos.DataSource = utils.ExecuteSPDataTable( spName, parameters );
            _totalRecords = dgvProductos.Rows.Count;
            _totalPages = (int)Math.Ceiling( (double)_totalRecords / _pageSize );
            DisplayPageInfo();

            if ( dgvProductos.Columns.Contains( "ProductoID" ) )
                dgvProductos.Columns["ProductoID"].Visible = false;
        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} productos";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }

        public void SetComboBoxData()
        {
            var categorias = utils.ExecuteViewDataTable( "vGetCategorias" );
            cmbCategorias.DataSource = categorias;
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "CategoriaID";
        }

        public void ClearFields()
        {
            txtNombre.Text = string.Empty;
            cmbCategorias.SelectedIndex = -1;
            txtNombreCategoria.Text = string.Empty;
            txtUnidad.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
        }

        private void btnNuevaCat_Click( object sender, EventArgs e )
        {
            tabControl.TabPages.Remove( tbpLista );
            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Add( tbpNuevaCategoria );
            tabControl.SelectedTab = tbpNuevaCategoria;
        }

        private void btnAgregar_Click( object sender, EventArgs e )
        {
            isEditing = false;
            lblCategoriaID.Visible = false;
            txtCategoriaID.Visible = false;

            tabControl.TabPages.Remove( tbpLista );
            tabControl.TabPages.Remove( tbpNuevaCategoria );
            tabControl.TabPages.Add( tbpDetalle );
            tabControl.SelectedTab = tbpDetalle;
            btnGuardar.Text = "Guardar";
        }

        private void btnEditar_Click( object sender, EventArgs e )
        {
            var selectedRow = dgvProductos.CurrentRow.DataBoundItem as DataRowView;
            if ( selectedRow != null )
            {
                isEditing = true;
                lblCategoriaID.Visible = true;
                txtCategoriaID.Visible = true;
                btnGuardar.Text = "Actualizar";

                tabControl.TabPages.Remove( tbpLista );
                tabControl.TabPages.Remove( tbpNuevaCategoria );
                tabControl.TabPages.Add( tbpDetalle );
                tabControl.SelectedTab = tbpDetalle;
                tbpDetalle.Text = "Editar Producto";

                Dictionary<string, dynamic> parameters = new()
                {
                    { "@ID", selectedRow["ProductoID"] }
                };

                var productoDetails = utils.ExecuteSPDataTable( "spGetProductoByID", parameters );
                if ( productoDetails.Rows.Count > 0 )
                {
                    DataRow row = productoDetails.Rows[0];
                    txtProductoID.Text = row["ProductoID"].ToString();
                    txtCategoriaID.Text = row["CategoriaID"].ToString();
                    txtNombre.Text = row["Nombre"].ToString();
                    cmbCategorias.SelectedValue = row["CategoriaID"];
                    txtUnidad.Text = row["ContenidoPorUnidad"].ToString();
                }
            }
        }

        private void btnGuardar_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@ProductoID", txtProductoID.Text.Trim() },
                { "@Nombre", txtNombre.Text.Trim() },
                { "@CategoriaID", cmbCategorias.SelectedValue! },
                { "@ContenidoPorUnidad", txtUnidad.Text.Trim() }
            };

            if ( isEditing )
            {
                parameters.Add( "@ID", Convert.ToInt32( txtProductoID.Text ) );
                utils.ExecuteSPDataTable( "spUpdateProducto", parameters );
                MessageBox.Show( "Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                utils.ExecuteSPDataTable( "spInsertProducto", parameters );
                MessageBox.Show( "Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }

            SetListBindingSource();
            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Remove( tbpNuevaCategoria );
            tabControl.TabPages.Add( tbpLista );
            tabControl.SelectedTab = tbpLista;
            ClearFields();
        }

        private void btnCancelar_Click( object sender, EventArgs e )
        {
            tabControl.TabPages.Remove( tbpDetalle );
            tabControl.TabPages.Remove( tbpNuevaCategoria );
            tabControl.TabPages.Add( tbpLista );
            tabControl.SelectedTab = tbpLista;
            ClearFields();
        }

        private void btnGuardarCategoria_Click( object sender, EventArgs e )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@Nombre", txtNombreCategoria.Text.Trim() },
                { "@Observaciones", txtObservaciones.Text.Trim() }
            };

            utils.ExecuteSPDataTable( "spInsertCategoria", parameters );
            tabControl.TabPages.Remove( tbpNuevaCategoria );
            tabControl.TabPages.Add( tbpLista );
            tabControl.SelectedTab = tbpLista;
            SetComboBoxData();
            ClearFields();

            MessageBox.Show( "Categoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void btnCancelarCat_Click( object sender, EventArgs e )
        {
            tabControl.TabPages.Remove( tbpNuevaCategoria );
            tabControl.TabPages.Add( tbpLista );
            tabControl.SelectedTab = tbpLista;
            ClearFields();
        }
    }
}
