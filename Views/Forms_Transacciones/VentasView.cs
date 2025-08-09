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
using System.Windows.Media.TextFormatting;

namespace ProyectoBD2.Views.Forms
{
    public partial class VentasView : Form
    {
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;
        private readonly Utils utils = new();
        private string ConsultaActual = "";

        public VentasView()
        {
            InitializeComponent();
            SetListBindingSource("spObtenerVentas");
            CargarProductores();
        }

        public void SetListBindingSource(string spName = "spObtenerVentas", Dictionary<string, dynamic>? parameters = null)
        {
            _actualPage = 1;
            _pageSize = 25;
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvStock.DataSource = utils.ExecuteSPDataTable(spName, parameters);

            _totalRecords = dgvStock.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            DisplayPageInfo();

        }

        public void CargarStock(string spName = "spObtenerStock", Dictionary<string, dynamic>? parameters = null)
        {
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvStock.DataSource = utils.ExecuteSPDataTable(spName, parameters);

            _totalRecords = dgvStock.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            DisplayPageInfo();

            if (dgvStock.Columns.Contains("ProductorID"))
                dgvStock.Columns["ProductorID"].Visible = false;
            if (dgvStock.Columns.Contains("EstadoID"))
                dgvStock.Columns["EstadoID"].Visible = false;
        }

        public void CargarProductores()
        {
            var estados = utils.ExecuteSPDataTable("spObtenerProveedor");

            cmbProductor.DataSource ??= estados.AsEnumerable().Select(row => new
            {
                Nombre = row["NombreProveedor"],
                ProveedorID = row["ProveedorID"]
            }).ToList();

            cmbProductor.DisplayMember = "Nombre";
            cmbProductor.ValueMember = "ProveedorID";
        }

        public void CargarProductos()
        {
            var estados = utils.ExecuteSPDataTable("spObtenerProducto");

            cmbProducto.DataSource ??= estados.AsEnumerable().Select(row => new
            {
                Nombre = row["Nombre"],
                ProductoID = row["ProductoID"]
            }).ToList();

            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "ProductoID";
        }
        public void CargarBodegas()
        {
            var estados = utils.ExecuteSPDataTable("spObtenerBodega");

            cmbBodega.DataSource ??= estados.AsEnumerable().Select(row => new
            {
                Nombre = row["BodegaID"],
            }).ToList();

            cmbBodega.DisplayMember = "Nombre";
            cmbBodega.ValueMember = "Nombre";
        }
        public void CargarFacturas(string spName = "spGetAllFacturas", Dictionary<string, dynamic>? parameters = null)
        {
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvStock.DataSource = utils.ExecuteSPDataTable(spName, parameters);

            _totalRecords = dgvStock.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            DisplayPageInfo();

            if (dgvStock.Columns.Contains("ProductorID"))
                dgvStock.Columns["ProductorID"].Visible = false;
            if (dgvStock.Columns.Contains("EstadoID"))
                dgvStock.Columns["EstadoID"].Visible = false;
        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} productores";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProductor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", --_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource("spGetAllProductores", parameters);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", ++_actualPage },
                { "@PageSize", _pageSize }
            };
            SetListBindingSource("spGetAllProductores", parameters);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tboSolicitudInsumos.SelectedTab == tboRegistrarSolicitud)
            {
                dvProductosCompra.Columns.Add("ProductoID", "ProductoID");
                dvProductosCompra.Columns.Add("BodegaID", "BodegaID");
                dvProductosCompra.Columns.Add("Cantidad", "Cantidad");
                dvProductosCompra.Columns.Add("Precio", "Precio");
                CargarProductores();
                CargarProductos();
                CargarBodegas();
            }
            //else if (tboSolicitudInsumos.SelectedTab == tabPageProductos)
            //{
            //    ActualizarListaProductos();
            //    LimpiarFiltros();
            //}
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            dvProductosCompra.Rows.Add(cmbProducto.SelectedValue, cmbBodega.SelectedValue, txtCantidad.Text, txtPrecio.Text);
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btnCrearCompra_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> productor = new()
            {
                { "@ProveedorID",cmbProductor.SelectedValue }
            };
            Dictionary<string, dynamic> productos = new()
            {
                {"@ProductosTable", dvProductosCompra }
            };
            var result = new DataTable();

            result = utils.ExecuteSPDataTableTypeName("spCrearSolicitudInsumos", productor, productos);
           


            //if ((int)result.Rows[0]["Estado"] == 10000)
            //{
            //    SetListBindingSource();
            //    tabControl.TabPages.Remove(tbpDetalleProductor);
            //    tabControl.TabPages.Add(tbpLista);
            //    tabControl.SelectedTab = tbpLista;
            //    ClearFields();
            //}

            MessageBox.Show(result.Rows[0]["Mensaje"].ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
