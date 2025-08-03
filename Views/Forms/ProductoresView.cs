using ProyectoBD2.Presenters;
using ProyectoBD2.Repositories.Implementations;
using ProyectoBD2.Views.Interfaces;
using System.Data;

namespace ProyectoBD2.Views.Forms
{
    public partial class ProductoresView : Form, IProductorView
    {
        // Fields
        private readonly ProductorPresenter _presenter;
        private bool isSuccessful;
        private bool isEditing;
        private string message;

        // Constructor
        public ProductoresView()
        {
            InitializeComponent();
            AssociatedAndRaiseEvents();
            tabControl.TabPages.Remove(tbpDetalle);

            _presenter = new ProductorPresenter(this, new ProductoresRepository());

            if ( dgvProductores.Columns.Contains( "ProductorID" ) )
                dgvProductores.Columns["ProductorID"].Visible = false;
            if ( dgvProductores.Columns.Contains( "EstadoID" ) )
                dgvProductores.Columns["EstadoID"].Visible = false;

            cmbRecordsPerPage.SelectedIndex = 0;
            cmbEstado.SelectedIndex = -1;

            btnCerrar.Click += ( s, e ) => this.Close();
        }


        // Method to associate events with their handlers
        private void AssociatedAndRaiseEvents()
        {
            btnBuscar.Click += ( s, e ) => SearchEvent?.Invoke( this, EventArgs.Empty );
            btnSiguiente.Click += ( s, e ) => NextPageEvent?.Invoke( this, EventArgs.Empty );
            btnAnterior.Click += ( s, e ) => PrevPageEvent?.Invoke( this, EventArgs.Empty );
            txtBuscar.KeyDown += ( s, e ) =>
            {
                if ( e.KeyCode == Keys.Enter )
                {
                    SearchEvent?.Invoke( this, EventArgs.Empty );
                    e.SuppressKeyPress = true; // Prevents the beep sound
                }
            };

            btnAgregar.Click += delegate
            {
                AddNewEvent?.Invoke( this, EventArgs.Empty );
                tabControl.TabPages.Remove( tbpLista );
                tabControl.TabPages.Add( tbpDetalle );
                tabControl.SelectedTab = tbpDetalle;
                tbpDetalle.Text = "Nuevo Productor";
            };

            btnEditar.Click += delegate
            {
                EditEvent?.Invoke( this, EventArgs.Empty );
                tabControl.TabPages.Remove(tbpLista);
                tabControl.TabPages.Add(tbpDetalle);
                tabControl.SelectedTab = tbpDetalle;
                tbpDetalle.Text = "Editar Productor";
            };

            btnEliminar.Click += delegate
            {
                var result = MessageBox.Show("Esta seguro de eliminar este productor?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( result == DialogResult.Yes )
                {
                    DeleteEvent?.Invoke( this, EventArgs.Empty );
                    MessageBox.Show( Message );
                }
            };
            
            btnGuardar.Click += delegate
            {
                SaveEvent?.Invoke( this, EventArgs.Empty );
                if ( isSuccessful )
                {
                    tabControl.TabPages.Remove( tbpDetalle );
                    tabControl.TabPages.Add( tbpLista );
                    tabControl.SelectedTab = tbpLista;
                }
                MessageBox.Show( Message );
            };

            btnCancelar.Click += delegate
            {
                CancelEvent?.Invoke( this, EventArgs.Empty );
                tabControl.TabPages.Remove( tbpDetalle );
                tabControl.TabPages.Add( tbpLista );
                tabControl.SelectedTab = tbpLista;
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler NextPageEvent;
        public event EventHandler PrevPageEvent;

        public void SetListBindingSource( BindingSource productores )
        {
            dgvProductores.DataSource = productores;
        }

        public void DisplayPageRange( int currentPage, int totalPages, int totalRecords )
        {
            lblTotalRegistros.Text = $"Total: {totalRecords} productores";
            lblPaginas.Text = $"Página {currentPage} de {totalPages}";
            btnSiguiente.Enabled = currentPage < totalPages;
            btnAnterior.Enabled = currentPage > 1;
        }

        public void CargarEstados( DataTable estados )
        {
            cmbEstado.DataSource ??= estados.AsEnumerable().Select( row => new
            {
                Nombre = row["Nombre"],
                EstadoID = row["EstadoID"]
            } ).ToList();

            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "EstadoID";
        }

        public int EstadoID
        {
            get => cmbEstado.SelectedValue != null ? Convert.ToInt32(cmbEstado.SelectedValue) : 0;
            set => cmbEstado.SelectedValue = value;
        }

        public int ProductorID
        {
            get => int.TryParse( txtProductorID.Text.Trim(), out int id ) ? id : 0;
            set => txtProductorID.Text = value.ToString();
        }
        public string Nombre 
        { 
            get => txtNombre.Text.Trim();
            set => txtNombre.Text = value;
        }
        public string Apellido 
        {
            get => txtApellido.Text.Trim();
            set => txtApellido.Text = value;
        }
        public string Documento 
        {
            get => txtDocumento.Text.Trim();
            set => txtDocumento.Text = value;
        }
        public string RTN 
        {
            get => txtRTN.Text.Trim();
            set => txtRTN.Text = value;
        }
        public string Direccion 
        {
            get => txtDireccion.Text.Trim();
            set => txtDireccion.Text = value;
        }
        public string Telefono 
        {
            get => txtTelefono.Text.Trim();
            set => txtTelefono.Text = value;
        }
        public string Correo 
        {
            get => txtEmail.Text.Trim();
            set => txtEmail.Text = value;
        }

        public string SearchTerm {
            get => txtBuscar.Text.Trim();
            set => txtBuscar.Text = value;
        }
        public bool IsEditing 
        {
            get => isEditing;
            set
            {
                isEditing = value;
                lblProductorID.Visible = value;
                txtProductorID.Visible = value;
                btnGuardar.Text = value ? "Actualizar" : "Guardar";
            }
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message 
        {
            get => message;
            set => message = value;
        }
    }
}
