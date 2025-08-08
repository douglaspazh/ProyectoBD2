namespace ProyectoBD2.Views.Forms
{
    partial class ProductoresView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            panelTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            tabControl = new TabControl();
            tbpLista = new TabPage();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label6 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            tbpDetalleProductor = new TabPage();
            btnEliminar2 = new Button();
            txtApellido = new TextBox();
            label10 = new Label();
            txtRTN = new TextBox();
            label8 = new Label();
            txtDocumento = new TextBox();
            label7 = new Label();
            txtProductorID = new TextBox();
            lblProductorID = new Label();
            pictureBox = new PictureBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbEstado = new ComboBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            dgvProductores = new DataGridView();
            panelTop.SuspendLayout();
            tabControl.SuspendLayout();
            tbpLista.SuspendLayout();
            tbpDetalleProductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductores).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(816, 89);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 43);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(816, 140);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(114, 43);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(816, 209);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 4;
            label1.Text = "PRODUCTORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 15);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 5;
            label2.Text = "Buscar productor:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(9, 41);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un nombre o DNI";
            txtBuscar.Size = new Size(367, 29);
            txtBuscar.TabIndex = 6;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(387, 39);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 44);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnCerrar);
            panelTop.Controls.Add(iconButton1);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(949, 67);
            panelTop.TabIndex = 8;
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
            btnCerrar.Location = new Point(894, 8);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 48);
            btnCerrar.TabIndex = 7;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
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
            // tabControl
            // 
            tabControl.Controls.Add(tbpLista);
            tabControl.Controls.Add(tbpDetalleProductor);
            tabControl.Location = new Point(0, 67);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(949, 738);
            tabControl.TabIndex = 9;
            // 
            // tbpLista
            // 
            tbpLista.Controls.Add(lblRecordsPerPage);
            tbpLista.Controls.Add(cmbRecordsPerPage);
            tbpLista.Controls.Add(label6);
            tbpLista.Controls.Add(btnSiguiente);
            tbpLista.Controls.Add(btnAnterior);
            tbpLista.Controls.Add(lblPaginas);
            tbpLista.Controls.Add(lblTotalRegistros);
            tbpLista.Controls.Add(label2);
            tbpLista.Controls.Add(txtBuscar);
            tbpLista.Controls.Add(btnEliminar);
            tbpLista.Controls.Add(btnBuscar);
            tbpLista.Controls.Add(btnEditar);
            tbpLista.Controls.Add(dgvProductores);
            tbpLista.Controls.Add(btnAgregar);
            tbpLista.Location = new Point(4, 29);
            tbpLista.Margin = new Padding(3, 4, 3, 4);
            tbpLista.Name = "tbpLista";
            tbpLista.Padding = new Padding(3, 4, 3, 4);
            tbpLista.Size = new Size(941, 705);
            tbpLista.TabIndex = 0;
            tbpLista.Text = "Lista de Productores";
            tbpLista.UseVisualStyleBackColor = true;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(312, 664);
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size(189, 20);
            lblRecordsPerPage.TabIndex = 14;
            lblRecordsPerPage.Text = "({}) Productores por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            cmbRecordsPerPage.Location = new Point(234, 658);
            cmbRecordsPerPage.Margin = new Padding(3, 4, 3, 4);
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size(74, 29);
            cmbRecordsPerPage.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(169, 662);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 12;
            label6.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(706, 652);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(109, 40);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(591, 652);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(109, 40);
            btnAnterior.TabIndex = 10;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(490, 664);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(102, 20);
            lblPaginas.TabIndex = 9;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRegistros.Location = new Point(9, 662);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(162, 23);
            lblTotalRegistros.TabIndex = 8;
            lblTotalRegistros.Text = "Total: {} productores";
            // 
            // tbpDetalleProductor
            // 
            tbpDetalleProductor.Controls.Add(btnEliminar2);
            tbpDetalleProductor.Controls.Add(txtApellido);
            tbpDetalleProductor.Controls.Add(label10);
            tbpDetalleProductor.Controls.Add(txtRTN);
            tbpDetalleProductor.Controls.Add(label8);
            tbpDetalleProductor.Controls.Add(txtDocumento);
            tbpDetalleProductor.Controls.Add(label7);
            tbpDetalleProductor.Controls.Add(txtProductorID);
            tbpDetalleProductor.Controls.Add(lblProductorID);
            tbpDetalleProductor.Controls.Add(pictureBox);
            tbpDetalleProductor.Controls.Add(btnCancelar);
            tbpDetalleProductor.Controls.Add(btnGuardar);
            tbpDetalleProductor.Controls.Add(cmbEstado);
            tbpDetalleProductor.Controls.Add(label4);
            tbpDetalleProductor.Controls.Add(txtEmail);
            tbpDetalleProductor.Controls.Add(label3);
            tbpDetalleProductor.Controls.Add(txtTelefono);
            tbpDetalleProductor.Controls.Add(label5);
            tbpDetalleProductor.Controls.Add(txtNombre);
            tbpDetalleProductor.Controls.Add(lblNombre);
            tbpDetalleProductor.Location = new Point(4, 29);
            tbpDetalleProductor.Margin = new Padding(3, 4, 3, 4);
            tbpDetalleProductor.Name = "tbpDetalleProductor";
            tbpDetalleProductor.Padding = new Padding(3, 4, 3, 4);
            tbpDetalleProductor.Size = new Size(941, 705);
            tbpDetalleProductor.TabIndex = 1;
            tbpDetalleProductor.Text = "Detalle de Productor";
            tbpDetalleProductor.UseVisualStyleBackColor = true;
            // 
            // btnEliminar2
            // 
            btnEliminar2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar2.Location = new Point(506, 487);
            btnEliminar2.Margin = new Padding(3, 4, 3, 4);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(114, 40);
            btnEliminar2.TabIndex = 34;
            btnEliminar2.Text = "Eliminar";
            btnEliminar2.UseVisualStyleBackColor = true;
            btnEliminar2.Click += btnEliminar2_Click;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(457, 68);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.MaxLength = 25;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 29);
            txtApellido.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(457, 41);
            label10.Name = "label10";
            label10.Size = new Size(76, 23);
            label10.TabIndex = 32;
            label10.Text = "Apellido:";
            // 
            // txtRTN
            // 
            txtRTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRTN.Location = new Point(457, 153);
            txtRTN.Margin = new Padding(3, 4, 3, 4);
            txtRTN.MaxLength = 20;
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(175, 29);
            txtRTN.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(457, 127);
            label8.Name = "label8";
            label8.Size = new Size(45, 23);
            label8.TabIndex = 28;
            label8.Text = "RTN:";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(205, 153);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.MaxLength = 13;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(175, 29);
            txtDocumento.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(206, 127);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 26;
            label7.Text = "Documento:";
            // 
            // txtProductorID
            // 
            txtProductorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductorID.Location = new Point(728, 65);
            txtProductorID.Margin = new Padding(3, 4, 3, 4);
            txtProductorID.Name = "txtProductorID";
            txtProductorID.ReadOnly = true;
            txtProductorID.Size = new Size(114, 29);
            txtProductorID.TabIndex = 25;
            txtProductorID.TabStop = false;
            // 
            // lblProductorID
            // 
            lblProductorID.AutoSize = true;
            lblProductorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductorID.Location = new Point(728, 39);
            lblProductorID.Name = "lblProductorID";
            lblProductorID.Size = new Size(107, 23);
            lblProductorID.TabIndex = 24;
            lblProductorID.Text = "ProductorID:";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(29, 41);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(143, 166);
            pictureBox.TabIndex = 21;
            pictureBox.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Location = new Point(338, 487);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 40);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F);
            btnGuardar.Location = new Point(205, 487);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 9.75F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(206, 419);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(138, 29);
            cmbEstado.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(206, 392);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 17;
            label4.Text = "Estado:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(205, 327);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 29);
            txtEmail.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(205, 300);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 15;
            label3.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9.75F);
            txtTelefono.Location = new Point(206, 239);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 8;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(162, 29);
            txtTelefono.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(205, 212);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 13;
            label5.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(205, 65);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 29);
            txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(205, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre:";
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
            dgvProductores.Location = new Point(9, 89);
            dgvProductores.Margin = new Padding(3, 4, 3, 4);
            dgvProductores.MultiSelect = false;
            dgvProductores.Name = "dgvProductores";
            dgvProductores.ReadOnly = true;
            dgvProductores.RowHeadersVisible = false;
            dgvProductores.RowHeadersWidth = 25;
            dgvProductores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductores.Size = new Size(800, 562);
            dgvProductores.TabIndex = 0;
            // 
            // ProductoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 805);
            Controls.Add(tabControl);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductoresView";
            Text = "ProductoresForm";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            tabControl.ResumeLayout(false);
            tbpLista.ResumeLayout(false);
            tbpLista.PerformLayout();
            tbpDetalleProductor.ResumeLayout(false);
            tbpDetalleProductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductores).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Panel panelTop;
        private TabControl tabControl;
        private TabPage tbpDetalleProductor;
        private TabPage tbpLista;
        private PictureBox pictureBox;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cmbEstado;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblProductorID;
        private TextBox txtProductorID;
        private BindingSource productorBindingSource1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Label lblTotalRegistros;
        private Label lblPaginas;
        private Button btnSiguiente;
        private Button btnAnterior;
        private ComboBox cmbRecordsPerPage;
        private Label label6;
        private Label lblRecordsPerPage;
        private TextBox txtRTN;
        private Label label8;
        private TextBox txtDocumento;
        private Label label7;
        private TextBox txtApellido;
        private Label label10;
        private Button btnEliminar2;
        private DataGridView dgvProductores;
    }
}