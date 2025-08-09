namespace ProyectoBD2.Views.Forms_Transacciones
{
    partial class FacturasView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label14 = new Label();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dataGridView3 = new DataGridView();
            cmbClienteID = new ComboBox();
            txtDescripcion = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtImpuestos = new TextBox();
            txtDescuento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtFecha = new TextBox();
            label4 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            txtObservaciones = new TextBox();
            label12 = new Label();
            txtPrecio = new TextBox();
            label9 = new Label();
            txtCantidad = new TextBox();
            label8 = new Label();
            cmbBodegaID = new ComboBox();
            label6 = new Label();
            cmbFacturaID = new ComboBox();
            cmbProductorID = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            tabPage3 = new TabPage();
            label13 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label15 = new Label();
            comboBox5 = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            panelTop.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnCerrar);
            panelTop.Controls.Add(iconButton1);
            panelTop.Controls.Add(label7);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1032, 67);
            panelTop.TabIndex = 12;
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
            btnCerrar.Location = new Point(2462, 8);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 48);
            btnCerrar.TabIndex = 7;
            btnCerrar.UseVisualStyleBackColor = true;
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
            iconButton1.Location = new Point(14, 5);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(46, 53);
            iconButton1.TabIndex = 6;
            iconButton1.TabStop = false;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 20);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 4;
            label7.Text = "FACTURAS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 74);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1008, 555);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblRecordsPerPage);
            tabPage1.Controls.Add(cmbRecordsPerPage);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(lblPaginas);
            tabPage1.Controls.Add(lblTotalRegistros);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Controls.Add(cmbClienteID);
            tabPage1.Controls.Add(txtDescripcion);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtImpuestos);
            tabPage1.Controls.Add(txtDescuento);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtFecha);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1000, 522);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Informcion de Factura";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(473, 489);
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size(192, 20);
            lblRecordsPerPage.TabIndex = 57;
            lblRecordsPerPage.Text = "({}) Proveedores por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            cmbRecordsPerPage.Location = new Point(361, 480);
            cmbRecordsPerPage.Margin = new Padding(3, 4, 3, 4);
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size(74, 29);
            cmbRecordsPerPage.TabIndex = 56;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(286, 488);
            label14.Name = "label14";
            label14.Size = new Size(69, 23);
            label14.TabIndex = 55;
            label14.Text = "Mostrar";
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(671, 488);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(102, 20);
            lblPaginas.TabIndex = 54;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRegistros.Location = new Point(109, 489);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(164, 23);
            lblTotalRegistros.TabIndex = 53;
            lblTotalRegistros.Text = "Total: {} proveedores";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Location = new Point(159, 363);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 40);
            btnCancelar.TabIndex = 52;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F);
            btnGuardar.Location = new Point(39, 363);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 51;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(497, 25);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(485, 444);
            dataGridView3.TabIndex = 36;
            // 
            // cmbClienteID
            // 
            cmbClienteID.FormattingEnabled = true;
            cmbClienteID.Location = new Point(39, 53);
            cmbClienteID.Name = "cmbClienteID";
            cmbClienteID.Size = new Size(151, 28);
            cmbClienteID.TabIndex = 35;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9.75F);
            txtDescripcion.Location = new Point(39, 290);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 25;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(439, 37);
            txtDescripcion.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(39, 263);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 27;
            label5.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(39, 178);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 26;
            label3.Text = "Impuesto ";
            // 
            // txtImpuestos
            // 
            txtImpuestos.Font = new Font("Segoe UI", 9.75F);
            txtImpuestos.Location = new Point(39, 205);
            txtImpuestos.Margin = new Padding(3, 4, 3, 4);
            txtImpuestos.MaxLength = 25;
            txtImpuestos.Name = "txtImpuestos";
            txtImpuestos.Size = new Size(205, 29);
            txtImpuestos.TabIndex = 25;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 9.75F);
            txtDescuento.Location = new Point(39, 133);
            txtDescuento.Margin = new Padding(3, 4, 3, 4);
            txtDescuento.MaxLength = 25;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(205, 29);
            txtDescuento.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(39, 106);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 23;
            label2.Text = "Descuento ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(286, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 22;
            label1.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Segoe UI", 9.75F);
            txtFecha.Location = new Point(273, 53);
            txtFecha.Margin = new Padding(3, 4, 3, 4);
            txtFecha.MaxLength = 25;
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(205, 29);
            txtFecha.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(39, 25);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 18;
            label4.Text = "ClienteID";
            label4.Click += label4_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(comboBox5);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(txtObservaciones);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txtPrecio);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtCantidad);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(cmbBodegaID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(cmbFacturaID);
            tabPage2.Controls.Add(cmbProductorID);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1000, 522);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalle Factura";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(500, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(469, 462);
            dataGridView1.TabIndex = 47;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 9.75F);
            txtObservaciones.Location = new Point(55, 313);
            txtObservaciones.Margin = new Padding(3, 4, 3, 4);
            txtObservaciones.MaxLength = 25;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(439, 52);
            txtObservaciones.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.Location = new Point(55, 286);
            label12.Name = "label12";
            label12.Size = new Size(120, 23);
            label12.TabIndex = 45;
            label12.Text = "Observaciones";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9.75F);
            txtPrecio.Location = new Point(55, 229);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.MaxLength = 25;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(205, 29);
            txtPrecio.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(55, 202);
            label9.Name = "label9";
            label9.Size = new Size(57, 23);
            label9.TabIndex = 43;
            label9.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 9.75F);
            txtCantidad.Location = new Point(55, 145);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.MaxLength = 25;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(205, 29);
            txtCantidad.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(55, 118);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 41;
            label8.Text = "Cantidad";
            // 
            // cmbBodegaID
            // 
            cmbBodegaID.FormattingEnabled = true;
            cmbBodegaID.Location = new Point(299, 144);
            cmbBodegaID.Name = "cmbBodegaID";
            cmbBodegaID.Size = new Size(151, 28);
            cmbBodegaID.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(299, 118);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 39;
            label6.Text = "BodegaID";
            // 
            // cmbFacturaID
            // 
            cmbFacturaID.FormattingEnabled = true;
            cmbFacturaID.Location = new Point(55, 60);
            cmbFacturaID.Name = "cmbFacturaID";
            cmbFacturaID.Size = new Size(205, 28);
            cmbFacturaID.TabIndex = 38;
            // 
            // cmbProductorID
            // 
            cmbProductorID.FormattingEnabled = true;
            cmbProductorID.Location = new Point(299, 60);
            cmbProductorID.Name = "cmbProductorID";
            cmbProductorID.Size = new Size(151, 28);
            cmbProductorID.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(299, 34);
            label11.Name = "label11";
            label11.Size = new Size(97, 23);
            label11.TabIndex = 36;
            label11.Text = "ProductoID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(55, 34);
            label10.Name = "label10";
            label10.Size = new Size(82, 23);
            label10.TabIndex = 30;
            label10.Text = "FacturaID";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(txtBuscar);
            tabPage3.Controls.Add(btnBuscar);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1000, 522);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Facturas Detalles Registradas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 14);
            label13.Name = "label13";
            label13.Size = new Size(124, 23);
            label13.TabIndex = 26;
            label13.Text = "Buscar Factura:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(6, 40);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese ID de Factura Detalle";
            txtBuscar.Size = new Size(478, 29);
            txtBuscar.TabIndex = 27;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(500, 25);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 44);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 77);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(988, 439);
            dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(175, 401);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 54;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.Location = new Point(55, 401);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 40);
            button2.TabIndex = 53;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(388, 483);
            label15.Name = "label15";
            label15.Size = new Size(192, 20);
            label15.TabIndex = 62;
            label15.Text = "({}) Proveedores por página";
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            comboBox5.Location = new Point(276, 474);
            comboBox5.Margin = new Padding(3, 4, 3, 4);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(74, 29);
            comboBox5.TabIndex = 61;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(201, 482);
            label16.Name = "label16";
            label16.Size = new Size(69, 23);
            label16.TabIndex = 60;
            label16.Text = "Mostrar";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(586, 482);
            label17.Name = "label17";
            label17.Size = new Size(102, 20);
            label17.TabIndex = 59;
            label17.Text = "Página {} de {}";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(24, 483);
            label18.Name = "label18";
            label18.Size = new Size(164, 23);
            label18.TabIndex = 58;
            label18.Text = "Total: {} proveedores";
            // 
            // FacturasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 641);
            Controls.Add(tabControl1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FacturasView";
            Text = "Facturas";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label7;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtFecha;
        private Label label4;
        private Label label3;
        private TextBox txtImpuestos;
        private TextBox txtDescuento;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label10;
        private Label label11;
        private ComboBox cmbClienteID;
        private TextBox txtPrecio;
        private Label label9;
        private TextBox txtCantidad;
        private Label label8;
        private ComboBox cmbBodegaID;
        private Label label6;
        private ComboBox cmbFacturaID;
        private ComboBox cmbProductorID;
        private TextBox txtObservaciones;
        private Label label12;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label13;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblRecordsPerPage;
        private ComboBox cmbRecordsPerPage;
        private Label label14;
        private Label lblPaginas;
        private Label lblTotalRegistros;
        private Button button1;
        private Button button2;
        private Label label15;
        private ComboBox comboBox5;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}