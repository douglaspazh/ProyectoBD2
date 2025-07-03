using ProyectoBD2.Presenters;
using ProyectoBD2.Repositories.Implementations;
using ProyectoBD2.Views.Interfaces;

namespace ProyectoBD2.UI.Forms
{
    public partial class ProductoresForm : Form, IProductorView
    {
        // Fields
        private readonly ProductorPresenter _presenter;
        private bool isSuccessful;
        private bool isEditing;
        private string message;

        // Constructor
        public ProductoresForm()
        {
            InitializeComponent();
            AssociatedAndRaiseEvents();
            tabControl.TabPages.Remove(tbpDetalle);

            _presenter = new ProductorPresenter(this, new ProductoresRepository());

            dgvProductores.DataBindingComplete += ( s, e ) =>
            {
                if ( dgvProductores.Columns.Contains( "ProductorID" ) )                
                    dgvProductores.Columns["ProductorID"].Visible = false;
            };

            btnCerrar.Click += ( s, e ) => this.Close();
        }

        // Method to associate events with their handlers
        private void AssociatedAndRaiseEvents()
        {
            btnBuscar.Click += ( s, e ) => SearchEvent?.Invoke( this, EventArgs.Empty );
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
                // Hacer invisibles los campos de ID y Fecha de Registro
                lblProductorID.Visible = false;
                txtProductorID.Visible = false;
                lblFechaRegistro.Visible = false;
                txtFechaRegistro.Visible = false;

                AddNewEvent?.Invoke( this, EventArgs.Empty );
                tabControl.TabPages.Remove( tbpLista );
                tabControl.TabPages.Add( tbpDetalle );
                tabControl.SelectedTab = tbpDetalle;
                tbpDetalle.Text = "Nuevo Productor";
            };

            btnEditar.Click += delegate
            {
                // Hacer visibles los campos de ID y Fecha de Registro
                lblProductorID.Visible = true;
                txtProductorID.Visible = true;
                lblFechaRegistro.Visible = true;
                txtFechaRegistro.Visible = true;

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
                tabControl.TabPages.Remove(tbpDetalle);
                tabControl.TabPages.Add(tbpLista);
                tabControl.SelectedTab = tbpLista;
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public int ProductorID 
        {
            get => int.Parse(txtProductorID.Text.Trim());
            set => txtProductorID.Text = value.ToString();
        }
        public string Nombre 
        { 
            get => txtNombre.Text.Trim();
            set => txtNombre.Text = value;
        }
        public string Telefono 
        {
            get => txtTelefono.Text.Trim();
            set => txtTelefono.Text = value;
        }
        public string Email 
        {
            get => txtEmail.Text.Trim();
            set => txtEmail.Text = value;
        }
        public string Estado {
            get => cmbEstado.SelectedItem?.ToString() ?? string.Empty;
            set => cmbEstado.SelectedItem = value;
        }
        public string FechaRegistro 
        {
            get => txtFechaRegistro.Text;
            set => txtFechaRegistro.Text = value;
        }
        public string SearchTerm {
            get => txtBuscar.Text.Trim();
            set => txtBuscar.Text = value;
        }
        public bool IsEditing 
        {
            get => isEditing;
            set => isEditing = value;
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

        public void SetListBindingSource( BindingSource productores )
        {
            dgvProductores.DataSource = productores;
        }
    }
}
