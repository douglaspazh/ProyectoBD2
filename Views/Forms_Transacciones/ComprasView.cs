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
using System.Xml.Linq;

namespace ProyectoBD2.Views.Forms
{
    public partial class ComprasView : Form
    {
        //Fields
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;

        private int _actualPageCompras = 1;
        private int _pageSizeCompras = 25;
        private int _totalPagesCompras = 0;
        private int _totalRecordsCompras = 0;

        private bool isEditing;
        private string message = string.Empty;
        private readonly Utils utils = new();
        private DataTable _TablaProductoCompras;

        public ComprasView()
        {
            InitializeComponent();
            SetComboBoxData();
            setTablaProductoComprasSource();
            setTablaComprasSource();

            tabControl.TabPages.Remove(tbpGenerarCompra);
            tabControl.TabPages.Remove(tbpDetallesCompra);

        }

        public void setTablaProductoComprasSource()
        {
            _TablaProductoCompras = new DataTable();

            // Columnas OCULTAS para IDs
            _TablaProductoCompras.Columns.Add("ProductoID", typeof(string));
            _TablaProductoCompras.Columns.Add("BodegaID", typeof(string));

            // Columnas VISIBLES
            _TablaProductoCompras.Columns.Add("Producto", typeof(string));
            _TablaProductoCompras.Columns.Add("Bodega", typeof(string));
            _TablaProductoCompras.Columns.Add("Precio", typeof(decimal));
            _TablaProductoCompras.Columns.Add("Cantidad", typeof(int));
            _TablaProductoCompras.Columns.Add("Total", typeof(decimal));

            dvProductosCompra.DataSource = _TablaProductoCompras;

            // Ocultar columnas de IDs
            dvProductosCompra.Columns["ProductoID"].Visible = false;
            dvProductosCompra.Columns["BodegaID"].Visible = false;
        }
        public void setTablaComprasSource(string spName = "spGetAllCompras", Dictionary<string, dynamic>? parameters = null)
        {
            parameters ??= new()
            {
                { "@PageNumber", _actualPage },
                { "@PageSize", _pageSize }
            };

            var data = utils.ExecuteSPDataTable(spName, parameters);
            dgvProveedores.DataSource = data;

            _totalRecords = data.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            DisplayPageInfo();

        }
        public void SetComboBoxData()
        {
            // Load data for Productores combo box
            var proveedores = utils.ExecuteViewDataTable("vGetProveedores");
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "NombreCompleto";
            cmbProveedor.ValueMember = "ProveedorID";

            // Load data for Producto combo box
            var insumos = utils.ExecuteViewDataTable("vGetAllInsumos");
            cmbProducto.DataSource = insumos;
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "ProductoID";
            // Load data for Bodega combo box
            var bodegas = utils.ExecuteViewDataTable("vGetAllBodegas");
            cmbBodega.DataSource = bodegas;
            cmbBodega.DisplayMember = "BodegaID";
            cmbBodega.ValueMember = "BodegaID";
        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} Proveedores";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private decimal GetStockDisponible(string productoId)
        {
            DataTable inventario = utils.ExecuteViewDataTable("vInventarioPorProducto");

            DataRow[] rows = inventario.Select($"ProductoID = '{productoId}'");

            if (rows.Length > 0)
            {
                return Convert.ToDecimal(rows[0]["StockTotal"]);
            }

            return 0;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Obtener valores REALES (IDs) no solo textos
            string productoID = cmbProducto.SelectedValue?.ToString() ?? "";
            string bodegaID = cmbBodega.SelectedValue?.ToString() ?? "";
            string nombreProducto = cmbProducto.Text;
            string nombreBodega = cmbBodega.Text;

            decimal precio = decimal.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            decimal total = precio * cantidad;

            decimal stockP = GetStockDisponible(productoID);

            if (cantidad > stockP)
            {
                MessageBox.Show(
                    $"No hay suficiente stock para '{nombreProducto}'.\n" +
                    $"Stock disponible: {stockP}\n" +
                    $"Cantidad solicitada: {cantidad}",
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Buscar si ya existe el mismo PRODUCTO en la MISMA BODEGA
            DataRow existingRow = _TablaProductoCompras.AsEnumerable()
                .FirstOrDefault(r =>
                    r.Field<string>("ProductoID") == productoID &&
                    r.Field<string>("BodegaID") == bodegaID);

            if (existingRow != null)
            {
                int nuevaCantidad = existingRow.Field<int>("Cantidad") + cantidad;

                if (nuevaCantidad > stockP)
                {
                    MessageBox.Show(
                        $"No hay suficiente stock para '{nombreProducto}'.\n" +
                        $"Stock disponible: {stockP}\n" +
                        $"Cantidad solicitada total: {nuevaCantidad}",
                        "Stock insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                existingRow["Cantidad"] = nuevaCantidad;
                existingRow["Total"] = precio * nuevaCantidad;
            }
            else
            {

                _TablaProductoCompras.Rows.Add(
                    productoID,
                    bodegaID,
                    nombreProducto,
                    nombreBodega,
                    precio,
                    cantidad,
                    total
                );
            }

            // Actualizar total general
            decimal ltotal = 0;
            foreach (DataRow row in _TablaProductoCompras.Rows)
            {
                ltotal += Convert.ToDecimal(row["Total"]);
            }
            LabelTotalValue.Text = ltotal.ToString("N2");
        }

        private void tbpDetalleProductor_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvProductosCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Por favor selecciona un producto para eliminar.",
                    "Sin selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Confirmación antes de eliminar
            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar el producto seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
                return;

            // Tomar índice de la fila seleccionada
            int rowIndex = dvProductosCompra.SelectedRows[0].Index;

            // Eliminar de la DataTable
            _TablaProductoCompras.Rows.RemoveAt(rowIndex);

            // Recalcular el total general
            decimal ltotal = _TablaProductoCompras.AsEnumerable()
                .Sum(r => r.Field<decimal>("Total"));

            LabelTotalValue.Text = ltotal.ToString("N2");
        }

        private void btnCrearCompra_Click(object sender, EventArgs e)
        {
            // Validar que exista al menos una fila
            if (_TablaProductoCompras == null || _TablaProductoCompras.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la compra.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores de textboxes
            string impuesto = txtImpuesto.Text.Trim();
            string descuento = txtDescuento.Text.Trim();

            // Si están vacíos, asignar null
            if (string.IsNullOrWhiteSpace(impuesto)) impuesto = null;
            if (string.IsNullOrWhiteSpace(descuento)) descuento = null;


            var parameters = new Dictionary<string, dynamic>
            {
                { "@ProveedorID", Convert.ToInt32(cmbProveedor.SelectedValue) },
                { "@Impuesto", string.IsNullOrWhiteSpace(txtImpuesto.Text) ? null : txtImpuesto.Text.Trim() },
                { "@Descuento", string.IsNullOrWhiteSpace(txtDescuento.Text) ? null : txtDescuento.Text.Trim() },
                { "@Fecha", DateTime.Today.ToString("yyyy-MM-dd")}
            };

            if (parameters.ContainsKey("@ProductosTable"))
                parameters.Remove("@ProductosTable");

            try
            {

                DataTable tvpTable = new DataTable();
                tvpTable.Columns.Add("ProductoID", typeof(string));
                tvpTable.Columns.Add("BodegaID", typeof(string));
                tvpTable.Columns.Add("Cantidad", typeof(int));
                tvpTable.Columns.Add("Precio", typeof(string));

                foreach (DataRow row in _TablaProductoCompras.Rows)
                {
                    tvpTable.Rows.Add(
                        row["ProductoID"],
                        row["BodegaID"],
                        row["Cantidad"],
                        Convert.ToString(row["Precio"])
                    );
                }


                var result = utils.ExcuteSPDataTable(
                    "spComprarInsumos",
                    "ProductosTable",
                    "dbo.InsumoCompra",
                     tvpTable,
                     parameters
                    );

                MessageBox.Show("Compra registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                _TablaProductoCompras.Clear();

                LabelTotalValue.Text = "0.00";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tbpGenerarCompra);
            tabControl.TabPages.Remove(tbpComprasRegistradas);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tbpComprasRegistradas);
            _TablaProductoCompras.Clear();
            tabControl.TabPages.Remove(tbpGenerarCompra);
            
        }
    }
}
