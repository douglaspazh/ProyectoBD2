namespace ProyectoBD2.Views.Forms
{
    partial class ComprasView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tbpGenerarCompra = new TabPage();
            btnCancelar = new Button();
            LabelTotalValue = new Label();
            labelTotal = new Label();
            panel1 = new Panel();
            dvProductosCompra = new DataGridView();
            btnEliminar = new Button();
            txtDescuento = new TextBox();
            groupBox1 = new GroupBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            cmbBodega = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            cmbProducto = new ComboBox();
            label8 = new Label();
            btnAgregarProducto = new Button();
            txtImpuesto = new TextBox();
            label10 = new Label();
            btnCrearCompra = new Button();
            cmbProveedor = new ComboBox();
            label4 = new Label();
            lblNombre = new Label();
            tabControl = new TabControl();
            tbpComprasRegistradas = new TabPage();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label6 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            label3 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvProveedores = new DataGridView();
            btnAgregarCompra = new Button();
            tbpDetallesCompra = new TabPage();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            panelTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            tbpGenerarCompra.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).BeginInit();
            groupBox1.SuspendLayout();
            tabControl.SuspendLayout();
            tbpComprasRegistradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // tbpGenerarCompra
            // 
            tbpGenerarCompra.Controls.Add(btnCancelar);
            tbpGenerarCompra.Controls.Add(LabelTotalValue);
            tbpGenerarCompra.Controls.Add(labelTotal);
            tbpGenerarCompra.Controls.Add(panel1);
            tbpGenerarCompra.Controls.Add(btnEliminar);
            tbpGenerarCompra.Controls.Add(txtDescuento);
            tbpGenerarCompra.Controls.Add(groupBox1);
            tbpGenerarCompra.Controls.Add(txtImpuesto);
            tbpGenerarCompra.Controls.Add(label10);
            tbpGenerarCompra.Controls.Add(btnCrearCompra);
            tbpGenerarCompra.Controls.Add(cmbProveedor);
            tbpGenerarCompra.Controls.Add(label4);
            tbpGenerarCompra.Controls.Add(lblNombre);
            tbpGenerarCompra.Location = new Point(4, 24);
            tbpGenerarCompra.Name = "tbpGenerarCompra";
            tbpGenerarCompra.Padding = new Padding(3);
            tbpGenerarCompra.Size = new Size(822, 526);
            tbpGenerarCompra.TabIndex = 1;
            tbpGenerarCompra.Text = "Generar Compra";
            tbpGenerarCompra.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(328, 441);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 33);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // LabelTotalValue
            // 
            LabelTotalValue.AutoSize = true;
            LabelTotalValue.Font = new Font("Segoe UI", 9.75F);
            LabelTotalValue.Location = new Point(68, 449);
            LabelTotalValue.Name = "LabelTotalValue";
            LabelTotalValue.Size = new Size(15, 17);
            LabelTotalValue.TabIndex = 45;
            LabelTotalValue.Text = "0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 9.75F);
            labelTotal.Location = new Point(19, 449);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(43, 17);
            labelTotal.TabIndex = 44;
            labelTotal.Text = "Total :";
            // 
            // panel1
            // 
            panel1.Controls.Add(dvProductosCompra);
            panel1.Location = new Point(19, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 338);
            panel1.TabIndex = 43;
            // 
            // dvProductosCompra
            // 
            dvProductosCompra.AllowUserToAddRows = false;
            dvProductosCompra.AllowUserToDeleteRows = false;
            dvProductosCompra.AllowUserToResizeColumns = false;
            dvProductosCompra.AllowUserToResizeRows = false;
            dvProductosCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvProductosCompra.BorderStyle = BorderStyle.None;
            dvProductosCompra.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dvProductosCompra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvProductosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvProductosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvProductosCompra.Dock = DockStyle.Fill;
            dvProductosCompra.EnableHeadersVisualStyles = false;
            dvProductosCompra.Location = new Point(0, 0);
            dvProductosCompra.MultiSelect = false;
            dvProductosCompra.Name = "dvProductosCompra";
            dvProductosCompra.ReadOnly = true;
            dvProductosCompra.RowHeadersVisible = false;
            dvProductosCompra.RowHeadersWidth = 25;
            dvProductosCompra.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvProductosCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvProductosCompra.Size = new Size(564, 338);
            dvProductosCompra.TabIndex = 39;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F);
            btnEliminar.Location = new Point(589, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 30);
            btnEliminar.TabIndex = 42;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 9.75F);
            txtDescuento.Location = new Point(414, 52);
            txtDescuento.MaxLength = 25;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(169, 25);
            txtDescuento.TabIndex = 41;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(cmbBodega);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnAgregarProducto);
            groupBox1.Location = new Point(589, 141);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(219, 322);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agrega Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9.75F);
            txtPrecio.Location = new Point(26, 167);
            txtPrecio.MaxLength = 8;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(154, 25);
            txtPrecio.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(26, 147);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 38;
            label2.Text = "Precio:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 9.75F);
            txtCantidad.Location = new Point(26, 221);
            txtCantidad.MaxLength = 8;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(154, 25);
            txtCantidad.TabIndex = 14;
            // 
            // cmbBodega
            // 
            cmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBodega.Font = new Font("Segoe UI", 9.75F);
            cmbBodega.FormattingEnabled = true;
            cmbBodega.Location = new Point(30, 112);
            cmbBodega.Name = "cmbBodega";
            cmbBodega.Size = new Size(150, 25);
            cmbBodega.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(26, 201);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 13;
            label5.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 36;
            label1.Text = "Producto:";
            label1.Click += label1_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 9.75F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(30, 55);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(150, 25);
            cmbProducto.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 92);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 28;
            label8.Text = "Bodega:";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Segoe UI", 9.75F);
            btnAgregarProducto.Location = new Point(26, 264);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(153, 30);
            btnAgregarProducto.TabIndex = 20;
            btnAgregarProducto.Text = "Agregar Produto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Font = new Font("Segoe UI", 9.75F);
            txtImpuesto.Location = new Point(215, 49);
            txtImpuesto.MaxLength = 25;
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(180, 25);
            txtImpuesto.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(414, 32);
            label10.Name = "label10";
            label10.Size = new Size(72, 17);
            label10.TabIndex = 32;
            label10.Text = "Descuento:";
            // 
            // btnCrearCompra
            // 
            btnCrearCompra.Font = new Font("Segoe UI", 9.75F);
            btnCrearCompra.Location = new Point(149, 441);
            btnCrearCompra.Name = "btnCrearCompra";
            btnCrearCompra.Size = new Size(131, 33);
            btnCrearCompra.TabIndex = 19;
            btnCrearCompra.Text = "Crear Compra";
            btnCrearCompra.UseVisualStyleBackColor = true;
            btnCrearCompra.Click += btnCrearCompra_Click;
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Font = new Font("Segoe UI", 9.75F);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(19, 49);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(161, 25);
            cmbProveedor.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(19, 28);
            label4.Name = "label4";
            label4.Size = new Size(143, 17);
            label4.TabIndex = 17;
            label4.Text = "Seleccionar proveedor:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(215, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 17);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Impuesto:";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tbpGenerarCompra);
            tabControl.Controls.Add(tbpComprasRegistradas);
            tabControl.Controls.Add(tbpDetallesCompra);
            tabControl.Location = new Point(2, 51);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(830, 554);
            tabControl.TabIndex = 10;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tbpComprasRegistradas
            // 
            tbpComprasRegistradas.Controls.Add(lblRecordsPerPage);
            tbpComprasRegistradas.Controls.Add(cmbRecordsPerPage);
            tbpComprasRegistradas.Controls.Add(label6);
            tbpComprasRegistradas.Controls.Add(btnSiguiente);
            tbpComprasRegistradas.Controls.Add(btnAnterior);
            tbpComprasRegistradas.Controls.Add(lblPaginas);
            tbpComprasRegistradas.Controls.Add(lblTotalRegistros);
            tbpComprasRegistradas.Controls.Add(label3);
            tbpComprasRegistradas.Controls.Add(txtBuscar);
            tbpComprasRegistradas.Controls.Add(btnBuscar);
            tbpComprasRegistradas.Controls.Add(dgvProveedores);
            tbpComprasRegistradas.Controls.Add(btnAgregarCompra);
            tbpComprasRegistradas.Location = new Point(4, 24);
            tbpComprasRegistradas.Margin = new Padding(3, 2, 3, 2);
            tbpComprasRegistradas.Name = "tbpComprasRegistradas";
            tbpComprasRegistradas.Padding = new Padding(3, 2, 3, 2);
            tbpComprasRegistradas.Size = new Size(822, 526);
            tbpComprasRegistradas.TabIndex = 2;
            tbpComprasRegistradas.Text = "Compras registradas";
            tbpComprasRegistradas.UseVisualStyleBackColor = true;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(274, 497);
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size(134, 15);
            lblRecordsPerPage.TabIndex = 28;
            lblRecordsPerPage.Text = "({}) Compras por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            cmbRecordsPerPage.Location = new Point(206, 493);
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size(65, 25);
            cmbRecordsPerPage.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(149, 496);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 26;
            label6.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(715, 491);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(95, 30);
            btnSiguiente.TabIndex = 25;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(614, 491);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(95, 30);
            btnAnterior.TabIndex = 24;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(430, 497);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(81, 15);
            lblPaginas.TabIndex = 23;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRegistros.Location = new Point(9, 496);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(108, 17);
            lblTotalRegistros.TabIndex = 22;
            lblTotalRegistros.Text = "Total: {} Compras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 10);
            label3.Name = "label3";
            label3.Size = new Size(189, 17);
            label3.TabIndex = 19;
            label3.Text = "Buscar compra por proveedor:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(9, 30);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un nombre o DNI";
            txtBuscar.Size = new Size(322, 25);
            txtBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(340, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 33);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AllowUserToResizeColumns = false;
            dgvProveedores.AllowUserToResizeRows = false;
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.Location = new Point(9, 66);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 25;
            dgvProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(801, 422);
            dgvProveedores.TabIndex = 15;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCompra.Location = new Point(677, 30);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(132, 32);
            btnAgregarCompra.TabIndex = 16;
            btnAgregarCompra.Text = "Crear compra";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // tbpDetallesCompra
            // 
            tbpDetallesCompra.Location = new Point(4, 24);
            tbpDetallesCompra.Margin = new Padding(3, 2, 3, 2);
            tbpDetallesCompra.Name = "tbpDetallesCompra";
            tbpDetallesCompra.Padding = new Padding(3, 2, 3, 2);
            tbpDetallesCompra.Size = new Size(822, 526);
            tbpDetallesCompra.TabIndex = 3;
            tbpDetallesCompra.Text = "Detalles de la compra";
            tbpDetallesCompra.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(12, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 40);
            iconButton1.TabIndex = 6;
            iconButton1.TabStop = false;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 15);
            label7.Name = "label7";
            label7.Size = new Size(70, 17);
            label7.TabIndex = 4;
            label7.Text = "COMPRAS";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnCerrar);
            panelTop.Controls.Add(iconButton1);
            panelTop.Controls.Add(label7);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(844, 50);
            panelTop.TabIndex = 11;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCerrar.IconColor = Color.Black;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 28;
            btnCerrar.Location = new Point(1426, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 36);
            btnCerrar.TabIndex = 7;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // ComprasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 617);
            Controls.Add(panelTop);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ComprasView";
            Text = "ComprasView";
            tbpGenerarCompra.ResumeLayout(false);
            tbpGenerarCompra.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl.ResumeLayout(false);
            tbpComprasRegistradas.ResumeLayout(false);
            tbpComprasRegistradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tbpGenerarCompra;
        private TextBox txtApellido;
        private TextBox txtCantidad;
        private TextBox txtImpuesto;
        private Label label10;
        private Label label8;
        private Button btnAgregarProducto;
        private Button btnCrearCompra;
        private ComboBox cmbProveedor;
        private Label label4;
        private Label label5;
        private Label lblNombre;
        private TabControl tabControl;
        private ComboBox cmbProducto;
        private Label label1;
        private ComboBox cmbBodega;
        private GroupBox groupBox1;
        private DataGridView dvProductosCompra;
        private Button btnEliminar;
        private TextBox txtDescuento;
        private TextBox txtPrecio;
        private Label label2;
        private TabPage tbpComprasRegistradas;
        private TabPage tbpDetallesCompra;
        private Label lblRecordsPerPage;
        private ComboBox cmbRecordsPerPage;
        private Label label6;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblPaginas;
        private Label lblTotalRegistros;
        private Label label3;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvProveedores;
        private Button btnAgregarCompra;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label7;
        private Panel panelTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Panel panel1;
        private Label LabelTotalValue;
        private Label labelTotal;
        private Button btnCancelar;
    }
}