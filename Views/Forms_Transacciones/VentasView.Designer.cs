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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgvDatos = new DataGridView();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label6 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            tabControl = new TabControl();
            tbpDetalleProductor = new TabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dvProductosCompra = new DataGridView();
            groupBox1 = new GroupBox();
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
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tabControl.SuspendLayout();
            tbpDetalleProductor.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToResizeColumns = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.Location = new Point(13, 26);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 25;
            dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(903, 555);
            dgvDatos.TabIndex = 29;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(316, 601);
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
            cmbRecordsPerPage.Location = new Point(238, 595);
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
            label6.Location = new Point(173, 599);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 34;
            label6.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(807, 589);
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
            btnAnterior.Location = new Point(692, 589);
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
            lblPaginas.Location = new Point(591, 601);
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
            lblTotalRegistros.Location = new Point(13, 599);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(162, 23);
            lblTotalRegistros.TabIndex = 30;
            lblTotalRegistros.Text = "Total: {} productores";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tbpDetalleProductor);
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(24, 13);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(949, 678);
            tabControl.TabIndex = 37;
            // 
            // tbpDetalleProductor
            // 
            tbpDetalleProductor.Controls.Add(button3);
            tbpDetalleProductor.Controls.Add(dvProductosCompra);
            tbpDetalleProductor.Controls.Add(groupBox1);
            tbpDetalleProductor.Controls.Add(btnCrearCompra);
            tbpDetalleProductor.Controls.Add(cmbProductor);
            tbpDetalleProductor.Controls.Add(label11);
            tbpDetalleProductor.Location = new Point(4, 29);
            tbpDetalleProductor.Margin = new Padding(3, 4, 3, 4);
            tbpDetalleProductor.Name = "tbpDetalleProductor";
            tbpDetalleProductor.Padding = new Padding(3, 4, 3, 4);
            tbpDetalleProductor.Size = new Size(941, 645);
            tbpDetalleProductor.TabIndex = 1;
            tbpDetalleProductor.Text = "Regitrar solicitud de insumos";
            tbpDetalleProductor.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDatos);
            tabPage1.Controls.Add(lblRecordsPerPage);
            tabPage1.Controls.Add(cmbRecordsPerPage);
            tabPage1.Controls.Add(lblTotalRegistros);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(lblPaginas);
            tabPage1.Controls.Add(btnSiguiente);
            tabPage1.Controls.Add(btnAnterior);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(941, 645);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Total de ventas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(941, 645);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Invetario de producto";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(19, 21);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(903, 555);
            dataGridView1.TabIndex = 37;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(322, 596);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 44;
            label1.Text = "({}) Productores por página";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            comboBox1.Location = new Point(244, 590);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(74, 29);
            comboBox1.TabIndex = 43;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 594);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 38;
            label2.Text = "Total: {} productores";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 594);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 42;
            label3.Text = "Mostrar";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(597, 596);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 39;
            label4.Text = "Página {} de {}";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(813, 584);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 41;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(698, 584);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(109, 40);
            button2.TabIndex = 40;
            button2.Text = "Anterior";
            button2.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dvProductosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            groupBox1.Size = new Size(250, 414);
            groupBox1.TabIndex = 49;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(30, 196);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 38;
            label5.Text = "Precio:";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(30, 268);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 13;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(34, 46);
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
            cmbProducto.Location = new Point(34, 73);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(171, 29);
            cmbProducto.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 123);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 28;
            label9.Text = "Bodega:";
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
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(941, 645);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Solicitudes de Insumos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 753);
            Controls.Add(tabControl);
            Name = "VentasView";
            Text = "VentasView";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tabControl.ResumeLayout(false);
            tbpDetalleProductor.ResumeLayout(false);
            tbpDetalleProductor.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvProductosCompra).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private Label lblRecordsPerPage;
        private ComboBox cmbRecordsPerPage;
        private Label label6;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblPaginas;
        private Label lblTotalRegistros;
        private TabControl tabControl;
        private TabPage tbpDetalleProductor;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
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
        private TabPage tabPage3;
    }
}