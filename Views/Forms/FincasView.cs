using ProyectoBD2.Models;
using ProyectoBD2.Presenters;
using ProyectoBD2.Repositories.Implementations;
using ProyectoBD2.Views.Interfaces;

namespace ProyectoBD2.Views.Forms
{
    public partial class FincasView : Form, IFincaView
    {
        // Fields
        private readonly FincaPresenter _presenter;
        private bool isSuccessful;
        private bool isEditing;
        private string message;

        // Constructor
        public FincasView()
        {
            InitializeComponent();
            AssociatedAndRaiseEvents();
            tabControl.TabPages.Remove(tbpDetalle);

            _presenter = new FincaPresenter(this, new FincasRepository());

            // Hide unnecessary columns in the DataGridView
            if ( dgvFincas.Columns.Contains("FincaID") )
                dgvFincas.Columns["FincaID"].Visible = false;
            if ( dgvFincas.Columns.Contains("ProductorID") )
                dgvFincas.Columns["ProductorID"].Visible = false;
            if ( dgvFincas.Columns.Contains("Productor") )
                dgvFincas.Columns["Productor"].Visible = false;

            btnCerrar.Click += ( s, e ) => this.Close();
        }

        private void AssociatedAndRaiseEvents()
        {
            btnBuscar.Click += ( s, e ) => SearchEvent?.Invoke(this, EventArgs.Empty);
            txtBuscar.KeyDown += ( s, e ) =>
            {
                if ( e.KeyCode == Keys.Enter )
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                    e.SuppressKeyPress = true; // Prevents the beep sound
                }
            };

            btnAgregar.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove( tbpLista );
                tabControl.TabPages.Add( tbpDetalle );
                tabControl.SelectedTab = tbpDetalle;
                tbpDetalle.Text = "Nueva Finca";
            };

            btnEditar.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tbpLista);
                tabControl.TabPages.Add(tbpDetalle);
                tabControl.SelectedTab = tbpDetalle;
                tbpDetalle.Text = "Editar Finca";
            };

            btnEliminar.Click += delegate
            {
                var result = MessageBox.Show("¿Está seguro de eliminar la finca seleccionada?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if ( result == DialogResult.Yes )
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show( Message );
                }
            };

            btnGuardar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if ( IsSuccessful )
                {
                    tabControl.TabPages.Remove(tbpDetalle);
                    tabControl.TabPages.Add(tbpLista);
                    tabControl.SelectedTab = tbpLista;
                    MessageBox.Show( Message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                else
                {
                    MessageBox.Show( Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            };

            btnCancelar.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
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

        public void SetListBindingSource( BindingSource fincas )
        {
            dgvFincas.DataSource = fincas;
        }

        public int FincaID
        {
            get => int.Parse(txtFincaID.Text.Trim());
            set => txtFincaID.Text = value.ToString();
        }
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
        public string ProductorNombre
        {
            get => cmbProductorNombre.Text.Trim();
            set => cmbProductorNombre.Text = value;
        }
        public string Direccion
        {
            get => txtDireccion.Text.Trim();
            set => txtDireccion.Text = value;
        }
        public decimal ExtensionTotal
        {
            get => decimal.Parse(txtExtensionTotal.Text.Trim());
            set => txtExtensionTotal.Text = value.ToString();
        }
        public string FechaRegistro
        {
            get => txtFechaRegistro.Text.Trim();
            set => txtFechaRegistro.Text = value;
        }
        public string SearchTerm
        {
            get => txtBuscar.Text.Trim();
            set => txtBuscar.Text = value;
        }
        public bool IsEditing
        {
            get => isEditing;
            set
            {
                isEditing = value;
                lblFincaID.Visible = value;
                txtFincaID.Visible = value;
                lblProductorID.Visible = value;
                txtProductorID.Visible = value;
                lblFechaRegistro.Visible = value;
                txtFechaRegistro.Visible = value;
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
