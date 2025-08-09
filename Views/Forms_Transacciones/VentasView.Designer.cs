namespace ProyectoBD2.Views.Forms
{
    partial class VentasView
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
            dgvStock = new DataGridView();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label6 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            tboSolicitudInsumos = new TabControl();
            tboRegistrarSolicitud = new TabPage();
            button3 = new Button();
            dvProductosCompra = new DataGridView();
            groupBox1 = new GroupBox();
            lblCantidadProducto = new Label();
            label1 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            cmbBodega = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cmbProducto = new ComboBox();
            label9 = new Label();
            btnAgregarProducto = new Button();
            btnCrearCompra = new Button();
            cmbProductor = new ComboBox();
            label11 = new Label();
            tboStock = new TabPage();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            tboSolicitudInsumos.SuspendLayout();
            tboRegistrarSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).BeginInit();
            groupBox1.SuspendLayout();
            tboStock.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BorderStyle = BorderStyle.None;
            dgvStock.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.Location = new Point(22, 107);
            dgvStock.Margin = new Padding(3, 4, 3, 4);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersVisible = false;
            dgvStock.RowHeadersWidth = 25;
            dgvStock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(990, 496);
            dgvStock.TabIndex = 29;
            dgvStock.CellContentClick += dgvDatos_CellContentClick;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(316, 623);
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size(189, 20);
            lblRecordsPerPage.TabIndex = 36;
            lblRecordsPerPage.Text = "({}) Productores por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            cmbRecordsPerPage.Location = new Point(238, 617);
            cmbRecordsPerPage.Margin = new Padding(3, 4, 3, 4);
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size(74, 29);
            cmbRecordsPerPage.TabIndex = 35;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(173, 621);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 34;
            label6.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(903, 611);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(109, 40);
            btnSiguiente.TabIndex = 33;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(788, 611);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(109, 40);
            btnAnterior.TabIndex = 32;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(687, 623);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(102, 20);
            lblPaginas.TabIndex = 31;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRegistros.Location = new Point(13, 621);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(162, 23);
            lblTotalRegistros.TabIndex = 30;
            lblTotalRegistros.Text = "Total: {} productores";
            // 
            // tboSolicitudInsumos
            // 
            tboSolicitudInsumos.Controls.Add(tboRegistrarSolicitud);
            tboSolicitudInsumos.Controls.Add(tboStock);
            tboSolicitudInsumos.Controls.Add(tabPage2);
            tboSolicitudInsumos.Location = new Point(24, 13);
            tboSolicitudInsumos.Margin = new Padding(3, 4, 3, 4);
            tboSolicitudInsumos.Name = "tboSolicitudInsumos";
            tboSolicitudInsumos.SelectedIndex = 0;
            tboSolicitudInsumos.Size = new Size(1045, 700);
            tboSolicitudInsumos.TabIndex = 37;
            tboSolicitudInsumos.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tboRegistrarSolicitud
            // 
            tboRegistrarSolicitud.Controls.Add(button3);
            tboRegistrarSolicitud.Controls.Add(dvProductosCompra);
            tboRegistrarSolicitud.Controls.Add(groupBox1);
            tboRegistrarSolicitud.Controls.Add(btnCrearCompra);
            tboRegistrarSolicitud.Controls.Add(cmbProductor);
            tboRegistrarSolicitud.Controls.Add(label11);
            tboRegistrarSolicitud.Location = new Point(4, 29);
            tboRegistrarSolicitud.Margin = new Padding(3, 4, 3, 4);
            tboRegistrarSolicitud.Name = "tboRegistrarSolicitud";
            tboRegistrarSolicitud.Padding = new Padding(3, 4, 3, 4);
            tboRegistrarSolicitud.Size = new Size(1037, 667);
            tboRegistrarSolicitud.TabIndex = 1;
            tboRegistrarSolicitud.Text = "Regitrar solicitud de insumos";
            tboRegistrarSolicitud.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F);
            button3.Location = new Point(668, 104);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(167, 40);
            button3.TabIndex = 52;
            button3.Text = "Eliminar Producto";
            button3.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvProductosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvProductosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvProductosCompra.EnableHeadersVisualStyles = false;
            dvProductosCompra.Location = new Point(22, 93);
            dvProductosCompra.Margin = new Padding(3, 4, 3, 4);
            dvProductosCompra.MultiSelect = false;
            dvProductosCompra.Name = "dvProductosCompra";
            dvProductosCompra.ReadOnly = true;
            dvProductosCompra.RowHeadersVisible = false;
            dvProductosCompra.RowHeadersWidth = 25;
            dvProductosCompra.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvProductosCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvProductosCompra.Size = new Size(628, 488);
            dvProductosCompra.TabIndex = 50;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCantidadProducto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(cmbBodega);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnAgregarProducto);
            groupBox1.Location = new Point(668, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 443);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agrega Producto";
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.AutoSize = true;
            lblCantidadProducto.Location = new Point(186, 42);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(17, 20);
            lblCantidadProducto.TabIndex = 41;
            lblCantidadProducto.Text = "0";
            lblCantidadProducto.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 42);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 40;
            label1.Text = "Cantidad Disponible:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9.75F);
            txtPrecio.Location = new Point(28, 255);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.MaxLength = 8;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(175, 29);
            txtPrecio.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(28, 228);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 38;
            label5.Text = "Precio:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 9.75F);
            txtCantidad.Location = new Point(28, 327);
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
            cmbBodega.Location = new Point(32, 182);
            cmbBodega.Margin = new Padding(3, 4, 3, 4);
            cmbBodega.Name = "cmbBodega";
            cmbBodega.Size = new Size(171, 29);
            cmbBodega.TabIndex = 37;
            cmbBodega.SelectedIndexChanged += cmbBodega_SelectedIndexChanged;
            cmbBodega.SelectionChangeCommitted += cmbBodega_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(28, 300);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 13;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(32, 78);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 36;
            label8.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 9.75F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(32, 105);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(171, 29);
            cmbProducto.TabIndex = 35;
            cmbProducto.SelectedIndexChanged += label2_Click;
            cmbProducto.SelectionChangeCommitted += cmbProducto_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 155);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 28;
            label9.Text = "Bodega:";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Segoe UI", 9.75F);
            btnAgregarProducto.Location = new Point(28, 384);
            btnAgregarProducto.Margin = new Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(175, 40);
            btnAgregarProducto.TabIndex = 20;
            btnAgregarProducto.Text = "Agregar Produto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnCrearCompra
            // 
            btnCrearCompra.Font = new Font("Segoe UI", 9.75F);
            btnCrearCompra.Location = new Point(21, 589);
            btnCrearCompra.Margin = new Padding(3, 4, 3, 4);
            btnCrearCompra.Name = "btnCrearCompra";
            btnCrearCompra.Size = new Size(177, 40);
            btnCrearCompra.TabIndex = 47;
            btnCrearCompra.Text = "Registrar Solicitud";
            btnCrearCompra.UseVisualStyleBackColor = true;
            btnCrearCompra.Click += btnCrearCompra_Click;
            // 
            // cmbProductor
            // 
            cmbProductor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductor.Font = new Font("Segoe UI", 9.75F);
            cmbProductor.FormattingEnabled = true;
            cmbProductor.Location = new Point(21, 56);
            cmbProductor.Margin = new Padding(3, 4, 3, 4);
            cmbProductor.Name = "cmbProductor";
            cmbProductor.Size = new Size(183, 29);
            cmbProductor.TabIndex = 46;
            cmbProductor.SelectedIndexChanged += cmbProductor_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(21, 29);
            label11.Name = "label11";
            label11.Size = new Size(177, 23);
            label11.TabIndex = 45;
            label11.Text = "Seleccionar productor";
            // 
            // tboStock
            // 
            tboStock.Controls.Add(button4);
            tboStock.Controls.Add(button2);
            tboStock.Controls.Add(button1);
            tboStock.Controls.Add(dgvStock);
            tboStock.Controls.Add(lblRecordsPerPage);
            tboStock.Controls.Add(cmbRecordsPerPage);
            tboStock.Controls.Add(lblTotalRegistros);
            tboStock.Controls.Add(label6);
            tboStock.Controls.Add(lblPaginas);
            tboStock.Controls.Add(btnSiguiente);
            tboStock.Controls.Add(btnAnterior);
            tboStock.Location = new Point(4, 29);
            tboStock.Name = "tboStock";
            tboStock.Padding = new Padding(3);
            tboStock.Size = new Size(1037, 667);
            tboStock.TabIndex = 2;
            tboStock.Text = "Total de ventas";
            tboStock.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(387, 42);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(191, 40);
            button4.TabIndex = 39;
            button4.Text = "Ver Stock Disponible";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(190, 42);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(191, 40);
            button2.TabIndex = 38;
            button2.Text = "Ver Stock Disponible";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 42);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(148, 40);
            button1.TabIndex = 37;
            button1.Text = "Ver Facturas";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1037, 667);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 753);
            Controls.Add(tboSolicitudInsumos);
            Name = "VentasView";
            Text = "VentasView";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            tboSolicitudInsumos.ResumeLayout(false);
            tboRegistrarSolicitud.ResumeLayout(false);
            tboRegistrarSolicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tboStock.ResumeLayout(false);
            tboStock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStock;
        private Label lblRecordsPerPage;
        private ComboBox cmbRecordsPerPage;
        private Label label6;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblPaginas;
        private Label lblTotalRegistros;
        private TabControl tboSolicitudInsumos;
        private TabPage tboRegistrarSolicitud;
        private TabPage tboStock;
        private Button button3;
        private DataGridView dvProductosCompra;
        private GroupBox groupBox1;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtCantidad;
        private ComboBox cmbBodega;
        private Label label7;
        private Label label8;
        private ComboBox cmbProducto;
        private Label label9;
        private Button btnAgregarProducto;
        private Button btnCrearCompra;
        private ComboBox cmbProductor;
        private Label label11;
        private Button button2;
        private Button button1;
        private Button button4;
        private TabPage tabPage2;
        private Label lblCantidadProducto;
        private Label label1;
    }
}