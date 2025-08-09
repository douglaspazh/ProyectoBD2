namespace ProyectoBD2.Views.Forms
{
    partial class ProveedoresView
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
            panelTop = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabListaProveedores = new TabPage();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label12 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvProveedores = new DataGridView();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            tbpDetalleProveedores = new TabPage();
            txtProveedorID = new TextBox();
            lblProveedorID = new Label();
            btnEliminar2 = new Button();
            btnCancelar = new Button();
            txtTasadeinteres = new TextBox();
            label11 = new Label();
            txtperiododepago = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtRTN = new TextBox();
            label8 = new Label();
            txtApellido = new TextBox();
            label6 = new Label();
            txtDocumento = new TextBox();
            label7 = new Label();
            pictureBox = new PictureBox();
            btnGuardar = new Button();
            cmbEstado = new ComboBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            panelTop.SuspendLayout();
            tabControl1.SuspendLayout();
            tabListaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            tbpDetalleProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(iconButton2);
            panelTop.Controls.Add(iconButton1);
            panelTop.Controls.Add(btnCerrar);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(969, 67);
            panelTop.TabIndex = 9;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.AutoSize = true;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 28;
            iconButton2.Location = new Point(916, 13);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(41, 48);
            iconButton2.TabIndex = 10;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(12, 4);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(46, 53);
            iconButton1.TabIndex = 9;
            iconButton1.TabStop = false;
            iconButton1.UseVisualStyleBackColor = true;
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
            btnCerrar.Location = new Point(1642, 7);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 48);
            btnCerrar.TabIndex = 7;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 4;
            label1.Text = "PROVEEDORES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabListaProveedores);
            tabControl1.Controls.Add(tbpDetalleProveedores);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(969, 615);
            tabControl1.TabIndex = 10;
            // 
            // tabListaProveedores
            // 
            tabListaProveedores.Controls.Add(lblRecordsPerPage);
            tabListaProveedores.Controls.Add(cmbRecordsPerPage);
            tabListaProveedores.Controls.Add(label12);
            tabListaProveedores.Controls.Add(btnSiguiente);
            tabListaProveedores.Controls.Add(btnAnterior);
            tabListaProveedores.Controls.Add(lblPaginas);
            tabListaProveedores.Controls.Add(lblTotalRegistros);
            tabListaProveedores.Controls.Add(btnEliminar);
            tabListaProveedores.Controls.Add(btnEditar);
            tabListaProveedores.Controls.Add(btnAgregar);
            tabListaProveedores.Controls.Add(dgvProveedores);
            tabListaProveedores.Controls.Add(label2);
            tabListaProveedores.Controls.Add(txtBuscar);
            tabListaProveedores.Controls.Add(btnBuscar);
            tabListaProveedores.Location = new Point(4, 29);
            tabListaProveedores.Name = "tabListaProveedores";
            tabListaProveedores.Padding = new Padding(3);
            tabListaProveedores.Size = new Size(961, 582);
            tabListaProveedores.TabIndex = 0;
            tabListaProveedores.Text = "Lista de Proveedores";
            tabListaProveedores.UseVisualStyleBackColor = true;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(322, 555);
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size(192, 20);
            lblRecordsPerPage.TabIndex = 36;
            lblRecordsPerPage.Text = "({}) Proveedores por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            cmbRecordsPerPage.Location = new Point(242, 546);
            cmbRecordsPerPage.Margin = new Padding(3, 4, 3, 4);
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size(74, 29);
            cmbRecordsPerPage.TabIndex = 35;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(167, 555);
            label12.Name = "label12";
            label12.Size = new Size(69, 23);
            label12.TabIndex = 34;
            label12.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(770, 538);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(109, 40);
            btnSiguiente.TabIndex = 33;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(655, 539);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(109, 40);
            btnAnterior.TabIndex = 32;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(517, 556);
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
            lblTotalRegistros.Location = new Point(7, 555);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(164, 23);
            lblTotalRegistros.TabIndex = 30;
            lblTotalRegistros.Text = "Total: {} proveedores";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(829, 162);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 40);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(829, 114);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 40);
            btnEditar.TabIndex = 28;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(829, 66);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 40);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.Location = new Point(6, 66);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 25;
            dgvProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(792, 460);
            dgvProveedores.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 23;
            label2.Text = "Buscar Proveedor:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(6, 29);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un nombre o DNI";
            txtBuscar.Size = new Size(478, 29);
            txtBuscar.TabIndex = 24;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(500, 14);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 44);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbpDetalleProveedores
            // 
            tbpDetalleProveedores.Controls.Add(txtDireccion);
            tbpDetalleProveedores.Controls.Add(txtProveedorID);
            tbpDetalleProveedores.Controls.Add(lblProveedorID);
            tbpDetalleProveedores.Controls.Add(btnEliminar2);
            tbpDetalleProveedores.Controls.Add(btnCancelar);
            tbpDetalleProveedores.Controls.Add(txtTasadeinteres);
            tbpDetalleProveedores.Controls.Add(label11);
            tbpDetalleProveedores.Controls.Add(txtperiododepago);
            tbpDetalleProveedores.Controls.Add(label10);
            tbpDetalleProveedores.Controls.Add(label9);
            tbpDetalleProveedores.Controls.Add(txtRTN);
            tbpDetalleProveedores.Controls.Add(label8);
            tbpDetalleProveedores.Controls.Add(txtApellido);
            tbpDetalleProveedores.Controls.Add(label6);
            tbpDetalleProveedores.Controls.Add(txtDocumento);
            tbpDetalleProveedores.Controls.Add(label7);
            tbpDetalleProveedores.Controls.Add(pictureBox);
            tbpDetalleProveedores.Controls.Add(btnGuardar);
            tbpDetalleProveedores.Controls.Add(cmbEstado);
            tbpDetalleProveedores.Controls.Add(label4);
            tbpDetalleProveedores.Controls.Add(txtEmail);
            tbpDetalleProveedores.Controls.Add(label3);
            tbpDetalleProveedores.Controls.Add(txtTelefono);
            tbpDetalleProveedores.Controls.Add(label5);
            tbpDetalleProveedores.Controls.Add(txtNombre);
            tbpDetalleProveedores.Controls.Add(lblNombre);
            tbpDetalleProveedores.Location = new Point(4, 29);
            tbpDetalleProveedores.Name = "tbpDetalleProveedores";
            tbpDetalleProveedores.Padding = new Padding(3);
            tbpDetalleProveedores.Size = new Size(961, 582);
            tbpDetalleProveedores.TabIndex = 1;
            tbpDetalleProveedores.Text = "Detalle Proveedores";
            tbpDetalleProveedores.UseVisualStyleBackColor = true;
            // 
            // txtProveedorID
            // 
            txtProveedorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProveedorID.Location = new Point(743, 53);
            txtProveedorID.Margin = new Padding(3, 4, 3, 4);
            txtProveedorID.Name = "txtProveedorID";
            txtProveedorID.ReadOnly = true;
            txtProveedorID.Size = new Size(114, 29);
            txtProveedorID.TabIndex = 53;
            txtProveedorID.TabStop = false;
            // 
            // lblProveedorID
            // 
            lblProveedorID.AutoSize = true;
            lblProveedorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProveedorID.Location = new Point(743, 27);
            lblProveedorID.Name = "lblProveedorID";
            lblProveedorID.Size = new Size(109, 23);
            lblProveedorID.TabIndex = 52;
            lblProveedorID.Text = "ProveedorID:";
            // 
            // btnEliminar2
            // 
            btnEliminar2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar2.Location = new Point(489, 475);
            btnEliminar2.Margin = new Padding(3, 4, 3, 4);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(114, 40);
            btnEliminar2.TabIndex = 51;
            btnEliminar2.Text = "Eliminar";
            btnEliminar2.UseVisualStyleBackColor = true;
            btnEliminar2.Click += btnEliminar2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Location = new Point(321, 475);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 40);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTasadeinteres
            // 
            txtTasadeinteres.Font = new Font("Segoe UI", 9.75F);
            txtTasadeinteres.Location = new Point(478, 407);
            txtTasadeinteres.Margin = new Padding(3, 4, 3, 4);
            txtTasadeinteres.MaxLength = 8;
            txtTasadeinteres.Name = "txtTasadeinteres";
            txtTasadeinteres.Size = new Size(162, 29);
            txtTasadeinteres.TabIndex = 49;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(478, 380);
            label11.Name = "label11";
            label11.Size = new Size(127, 23);
            label11.TabIndex = 48;
            label11.Text = "Tasa de Interes:";
            // 
            // txtperiododepago
            // 
            txtperiododepago.Font = new Font("Segoe UI", 9.75F);
            txtperiododepago.Location = new Point(478, 315);
            txtperiododepago.Margin = new Padding(3, 4, 3, 4);
            txtperiododepago.MaxLength = 8;
            txtperiododepago.Name = "txtperiododepago";
            txtperiododepago.Size = new Size(162, 29);
            txtperiododepago.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(478, 288);
            label10.Name = "label10";
            label10.Size = new Size(139, 23);
            label10.TabIndex = 46;
            label10.Text = "Periodo de Pago:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(478, 200);
            label9.Name = "label9";
            label9.Size = new Size(85, 23);
            label9.TabIndex = 44;
            label9.Text = "Direccion:";
            // 
            // txtRTN
            // 
            txtRTN.Font = new Font("Segoe UI", 9.75F);
            txtRTN.Location = new Point(478, 142);
            txtRTN.Margin = new Padding(3, 4, 3, 4);
            txtRTN.MaxLength = 25;
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(205, 29);
            txtRTN.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(478, 115);
            label8.Name = "label8";
            label8.Size = new Size(45, 23);
            label8.TabIndex = 42;
            label8.Text = "RTN:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9.75F);
            txtApellido.Location = new Point(478, 53);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.MaxLength = 25;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 29);
            txtApellido.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(478, 26);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 40;
            label6.Text = "Apellido:";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(201, 141);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.MaxLength = 13;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(175, 29);
            txtDocumento.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(202, 115);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 38;
            label7.Text = "Documento:";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(25, 29);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(143, 166);
            pictureBox.TabIndex = 37;
            pictureBox.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F);
            btnGuardar.Location = new Point(201, 475);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 9.75F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(202, 407);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(138, 29);
            cmbEstado.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(202, 380);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 34;
            label4.Text = "Estado:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(201, 315);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 29);
            txtEmail.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(201, 288);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 32;
            label3.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9.75F);
            txtTelefono.Location = new Point(202, 227);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 8;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(162, 29);
            txtTelefono.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(201, 200);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 30;
            label5.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(201, 53);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 29);
            txtNombre.TabIndex = 29;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(201, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 28;
            lblNombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9.75F);
            txtDireccion.Location = new Point(478, 227);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.MaxLength = 25;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(205, 29);
            txtDireccion.TabIndex = 54;
            // 
            // ProveedoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 682);
            Controls.Add(tabControl1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProveedoresView";
            Text = "Proveedores";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabListaProveedores.ResumeLayout(false);
            tabListaProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            tbpDetalleProveedores.ResumeLayout(false);
            tbpDetalleProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TabControl tabControl1;
        private TabPage tabListaProveedores;
        private TabPage tbpDetalleProveedores;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvProveedores;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtDocumento;
        private Label label7;
        private PictureBox pictureBox;
        private Button btnGuardar;
        private ComboBox cmbEstado;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label label6;
        private Label label10;
        private Label label9;
        private TextBox txtRTN;
        private Label label8;
        private TextBox txtTasadeinteres;
        private Label label11;
        private TextBox txtperiododepago;
        private Button btnEliminar2;
        private Button btnCancelar;
        private Label lblRecordsPerPage;
        private ComboBox cmbRecordsPerPage;
        private Label label12;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblTotalRegistros;
        private Label lblPaginas;
        private TextBox txtProveedorID;
        private Label lblProveedorID;
        private TextBox txtDireccion;
    }
}