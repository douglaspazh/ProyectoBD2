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
            tbpDetalleProductor = new TabPage();
            button1 = new Button();
            txtDescuento = new TextBox();
            dvProductosCompra = new DataGridView();
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
            tabPage1 = new TabPage();
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
            dgvProductores = new DataGridView();
            btnAgregar = new Button();
            tabPage2 = new TabPage();
            tbpDetalleProductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).BeginInit();
            groupBox1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductores).BeginInit();
            SuspendLayout();
            // 
            // tbpDetalleProductor
            // 
            tbpDetalleProductor.Controls.Add(button1);
            tbpDetalleProductor.Controls.Add(txtDescuento);
            tbpDetalleProductor.Controls.Add(dvProductosCompra);
            tbpDetalleProductor.Controls.Add(groupBox1);
            tbpDetalleProductor.Controls.Add(txtImpuesto);
            tbpDetalleProductor.Controls.Add(label10);
            tbpDetalleProductor.Controls.Add(btnCrearCompra);
            tbpDetalleProductor.Controls.Add(cmbProveedor);
            tbpDetalleProductor.Controls.Add(label4);
            tbpDetalleProductor.Controls.Add(lblNombre);
            tbpDetalleProductor.Location = new Point(4, 29);
            tbpDetalleProductor.Margin = new Padding(3, 4, 3, 4);
            tbpDetalleProductor.Name = "tbpDetalleProductor";
            tbpDetalleProductor.Padding = new Padding(3, 4, 3, 4);
            tbpDetalleProductor.Size = new Size(941, 705);
            tbpDetalleProductor.TabIndex = 1;
            tbpDetalleProductor.Text = "Generar Compra";
            tbpDetalleProductor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(668, 145);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(167, 40);
            button1.TabIndex = 42;
            button1.Text = "Eliminar Producto";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 9.75F);
            txtDescuento.Location = new Point(473, 70);
            txtDescuento.Margin = new Padding(3, 4, 3, 4);
            txtDescuento.MaxLength = 25;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(205, 29);
            txtDescuento.TabIndex = 41;
            // 
            // dvProductosCompra
            // 
            dvProductosCompra.AllowUserToAddRows = false;
            dvProductosCompra.AllowUserToDeleteRows = false;
            dvProductosCompra.AllowUserToResizeColumns = false;
            dvProductosCompra.AllowUserToResizeRows = false;
            dvProductosCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dvProductosCompra.EnableHeadersVisualStyles = false;
            dvProductosCompra.Location = new Point(22, 145);
            dvProductosCompra.Margin = new Padding(3, 4, 3, 4);
            dvProductosCompra.MultiSelect = false;
            dvProductosCompra.Name = "dvProductosCompra";
            dvProductosCompra.ReadOnly = true;
            dvProductosCompra.RowHeadersVisible = false;
            dvProductosCompra.RowHeadersWidth = 25;
            dvProductosCompra.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvProductosCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvProductosCompra.Size = new Size(628, 488);
            dvProductosCompra.TabIndex = 39;
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
            groupBox1.Location = new Point(668, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 414);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agrega Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9.75F);
            txtPrecio.Location = new Point(30, 223);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.MaxLength = 8;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(175, 29);
            txtPrecio.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(30, 196);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 38;
            label2.Text = "Precio:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 9.75F);
            txtCantidad.Location = new Point(30, 295);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.MaxLength = 8;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(175, 29);
            txtCantidad.TabIndex = 14;
            // 
            // cmbBodega
            // 
            cmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBodega.Font = new Font("Segoe UI", 9.75F);
            cmbBodega.FormattingEnabled = true;
            cmbBodega.Location = new Point(34, 150);
            cmbBodega.Margin = new Padding(3, 4, 3, 4);
            cmbBodega.Name = "cmbBodega";
            cmbBodega.Size = new Size(171, 29);
            cmbBodega.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(30, 268);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 13;
            label5.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(34, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 36;
            label1.Text = "Producto:";
            label1.Click += label1_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 9.75F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(34, 73);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(171, 29);
            cmbProducto.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 123);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 28;
            label8.Text = "Bodega:";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Segoe UI", 9.75F);
            btnAgregarProducto.Location = new Point(30, 352);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(175, 40);
            btnAgregarProducto.TabIndex = 20;
            btnAgregarProducto.Text = "Agregar Produto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Font = new Font("Segoe UI", 9.75F);
            txtImpuesto.Location = new Point(246, 65);
            txtImpuesto.Margin = new Padding(3, 4, 3, 4);
            txtImpuesto.MaxLength = 25;
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(205, 29);
            txtImpuesto.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(473, 43);
            label10.Name = "label10";
            label10.Size = new Size(95, 23);
            label10.TabIndex = 32;
            label10.Text = "Descuento:";
            // 
            // btnCrearCompra
            // 
            btnCrearCompra.Font = new Font("Segoe UI", 9.75F);
            btnCrearCompra.Location = new Point(22, 648);
            btnCrearCompra.Margin = new Padding(3, 4, 3, 4);
            btnCrearCompra.Name = "btnCrearCompra";
            btnCrearCompra.Size = new Size(150, 40);
            btnCrearCompra.TabIndex = 19;
            btnCrearCompra.Text = "Crear Compra";
            btnCrearCompra.UseVisualStyleBackColor = true;
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Font = new Font("Segoe UI", 9.75F);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(22, 65);
            cmbProveedor.Margin = new Padding(3, 4, 3, 4);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(183, 29);
            cmbProveedor.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(22, 38);
            label4.Name = "label4";
            label4.Size = new Size(183, 23);
            label4.TabIndex = 17;
            label4.Text = "Seleccionar proveedor:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(246, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 23);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Impuesto:";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tbpDetalleProductor);
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(12, 95);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(949, 738);
            tabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblRecordsPerPage);
            tabPage1.Controls.Add(cmbRecordsPerPage);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnSiguiente);
            tabPage1.Controls.Add(btnAnterior);
            tabPage1.Controls.Add(lblPaginas);
            tabPage1.Controls.Add(lblTotalRegistros);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(dgvProductores);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(941, 705);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Compras registradas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(313, 663);
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size(189, 20);
            lblRecordsPerPage.TabIndex = 28;
            lblRecordsPerPage.Text = "({}) Productores por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            cmbRecordsPerPage.Location = new Point(235, 657);
            cmbRecordsPerPage.Margin = new Padding(3, 4, 3, 4);
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size(74, 29);
            cmbRecordsPerPage.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(170, 661);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 26;
            label6.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(707, 651);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(109, 40);
            btnSiguiente.TabIndex = 25;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(592, 651);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(109, 40);
            btnAnterior.TabIndex = 24;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(491, 663);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(102, 20);
            lblPaginas.TabIndex = 23;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRegistros.Location = new Point(10, 661);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(162, 23);
            lblTotalRegistros.TabIndex = 22;
            lblTotalRegistros.Text = "Total: {} productores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 14);
            label3.Name = "label3";
            label3.Size = new Size(241, 23);
            label3.TabIndex = 19;
            label3.Text = "Buscar compra por proveedor:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(10, 40);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un nombre o DNI";
            txtBuscar.Size = new Size(367, 29);
            txtBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(388, 38);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 44);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductores
            // 
            dgvProductores.AllowUserToAddRows = false;
            dgvProductores.AllowUserToDeleteRows = false;
            dgvProductores.AllowUserToResizeColumns = false;
            dgvProductores.AllowUserToResizeRows = false;
            dgvProductores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductores.BorderStyle = BorderStyle.None;
            dgvProductores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProductores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductores.EnableHeadersVisualStyles = false;
            dgvProductores.Location = new Point(10, 88);
            dgvProductores.Margin = new Padding(3, 4, 3, 4);
            dgvProductores.MultiSelect = false;
            dgvProductores.Name = "dgvProductores";
            dgvProductores.ReadOnly = true;
            dgvProductores.RowHeadersVisible = false;
            dgvProductores.RowHeadersWidth = 25;
            dgvProductores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductores.Size = new Size(915, 562);
            dgvProductores.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(774, 40);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 43);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Crear compra";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(941, 705);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Detalles de la compra";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ComprasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 823);
            Controls.Add(tabControl);
            Name = "ComprasView";
            Text = "ComprasView";
            tbpDetalleProductor.ResumeLayout(false);
            tbpDetalleProductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tbpDetalleProductor;
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
        private Button button1;
        private TextBox txtDescuento;
        private TextBox txtPrecio;
        private Label label2;
        private TabPage tabPage1;
        private TabPage tabPage2;
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
        private DataGridView dgvProductores;
        private Button btnAgregar;
    }
}