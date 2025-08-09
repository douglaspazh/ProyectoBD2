namespace ProyectoBD2.Views.Forms
{
    partial class FincasView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            tabControl = new TabControl();
            tbpLista = new TabPage();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label6 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            btnNuevoLote = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvFincas = new DataGridView();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            tbpDetalle = new TabPage();
            label15 = new Label();
            txtProductorID = new TextBox();
            txtUbicacion = new TextBox();
            lblProductorID = new Label();
            cmbMunicipio = new ComboBox();
            txtFincaID = new TextBox();
            cmbDepartamento = new ComboBox();
            lblFincaID = new Label();
            cmbProductor = new ComboBox();
            label9 = new Label();
            txtExtensionTotal = new TextBox();
            label11 = new Label();
            txtNombre = new TextBox();
            label12 = new Label();
            btnCancelar = new Button();
            label13 = new Label();
            btnGuardar = new Button();
            label14 = new Label();
            tbpListaLotes = new TabPage();
            lblLotesPerPage = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            btnSiguiente2 = new Button();
            btnAnterior2 = new Button();
            lblLotesPages = new Label();
            lblTotalRegistrosLotes = new Label();
            btnEliminarLote = new Button();
            btnEditarLote = new Button();
            btnAgregarLote = new Button();
            dgvLotes = new DataGridView();
            label3 = new Label();
            txtBuscarLote = new TextBox();
            btnBuscarLote = new Button();
            tbpDetalleLote = new TabPage();
            btnCancelar2 = new Button();
            btnGuardarLote = new Button();
            txtLoteID = new TextBox();
            lblLoteID = new Label();
            txtTipoRiego = new TextBox();
            txtTipoSuelo = new TextBox();
            txtFincaID_Lote = new TextBox();
            txtExtencion = new TextBox();
            cmbFincas = new ComboBox();
            lblFincaID_Lote = new Label();
            label17 = new Label();
            label16 = new Label();
            label10 = new Label();
            label8 = new Label();
            panelTop.SuspendLayout();
            tabControl.SuspendLayout();
            tbpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFincas).BeginInit();
            tbpDetalle.SuspendLayout();
            tbpListaLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).BeginInit();
            tbpDetalleLote.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add( btnCerrar );
            panelTop.Controls.Add( iconButton1 );
            panelTop.Controls.Add( label1 );
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point( 0, 0 );
            panelTop.Name = "panelTop";
            panelTop.Size = new Size( 830, 50 );
            panelTop.TabIndex = 9;
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
            btnCerrar.Location = new Point( 782, 6 );
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size( 36, 36 );
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
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point( 12, 4 );
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size( 40, 40 );
            iconButton1.TabIndex = 6;
            iconButton1.TabStop = false;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0 );
            label1.Location = new Point( 48, 15 );
            label1.Name = "label1";
            label1.Size = new Size( 53, 17 );
            label1.TabIndex = 4;
            label1.Text = "FINCAS";
            // 
            // tabControl
            // 
            tabControl.Controls.Add( tbpLista );
            tabControl.Controls.Add( tbpDetalle );
            tabControl.Controls.Add( tbpListaLotes );
            tabControl.Controls.Add( tbpDetalleLote );
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point( 0, 50 );
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size( 830, 530 );
            tabControl.TabIndex = 10;
            // 
            // tbpLista
            // 
            tbpLista.Controls.Add( lblRecordsPerPage );
            tbpLista.Controls.Add( cmbRecordsPerPage );
            tbpLista.Controls.Add( label6 );
            tbpLista.Controls.Add( btnSiguiente );
            tbpLista.Controls.Add( btnAnterior );
            tbpLista.Controls.Add( lblPaginas );
            tbpLista.Controls.Add( lblTotalRegistros );
            tbpLista.Controls.Add( btnNuevoLote );
            tbpLista.Controls.Add( btnEliminar );
            tbpLista.Controls.Add( btnEditar );
            tbpLista.Controls.Add( btnAgregar );
            tbpLista.Controls.Add( dgvFincas );
            tbpLista.Controls.Add( label2 );
            tbpLista.Controls.Add( txtBuscar );
            tbpLista.Controls.Add( btnBuscar );
            tbpLista.Location = new Point( 4, 24 );
            tbpLista.Name = "tbpLista";
            tbpLista.Padding = new Padding( 3 );
            tbpLista.Size = new Size( 822, 502 );
            tbpLista.TabIndex = 0;
            tbpLista.Text = "Lista de Fincas";
            tbpLista.UseVisualStyleBackColor = true;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point( 273, 468 );
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size( 119, 15 );
            lblRecordsPerPage.TabIndex = 22;
            lblRecordsPerPage.Text = "({}) Fincas por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange( new object[] { "Auto", "10", "20", "30", "40", "50", "100" } );
            cmbRecordsPerPage.Location = new Point( 205, 463 );
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size( 65, 25 );
            cmbRecordsPerPage.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label6.Location = new Point( 148, 466 );
            label6.Name = "label6";
            label6.Size = new Size( 55, 17 );
            label6.TabIndex = 20;
            label6.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnSiguiente.Location = new Point( 617, 463 );
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size( 95, 30 );
            btnSiguiente.TabIndex = 19;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAnterior.Location = new Point( 516, 463 );
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size( 95, 30 );
            btnAnterior.TabIndex = 18;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point( 429, 468 );
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size( 81, 15 );
            lblPaginas.TabIndex = 17;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblTotalRegistros.Location = new Point( 8, 466 );
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size( 88, 17 );
            lblTotalRegistros.TabIndex = 16;
            lblTotalRegistros.Text = "Total: {} fincas";
            // 
            // btnNuevoLote
            // 
            btnNuevoLote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoLote.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnNuevoLote.Location = new Point( 716, 11 );
            btnNuevoLote.Name = "btnNuevoLote";
            btnNuevoLote.Size = new Size( 100, 32 );
            btnNuevoLote.TabIndex = 15;
            btnNuevoLote.Text = "Nuevo Lote";
            btnNuevoLote.UseVisualStyleBackColor = true;
            btnNuevoLote.Click += btnNuevoLote_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEliminar.Location = new Point( 716, 161 );
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size( 100, 32 );
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEditar.Location = new Point( 716, 102 );
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size( 100, 32 );
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAgregar.Location = new Point( 716, 64 );
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size( 100, 32 );
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvFincas
            // 
            dgvFincas.AllowUserToAddRows = false;
            dgvFincas.AllowUserToDeleteRows = false;
            dgvFincas.AllowUserToResizeColumns = false;
            dgvFincas.AllowUserToResizeRows = false;
            dgvFincas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFincas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFincas.BorderStyle = BorderStyle.None;
            dgvFincas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFincas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font( "Segoe UI", 9F );
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvFincas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvFincas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFincas.EnableHeadersVisualStyles = false;
            dgvFincas.Location = new Point( 8, 64 );
            dgvFincas.MultiSelect = false;
            dgvFincas.Name = "dgvFincas";
            dgvFincas.ReadOnly = true;
            dgvFincas.RowHeadersVisible = false;
            dgvFincas.RowHeadersWidth = 25;
            dgvFincas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvFincas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFincas.Size = new Size( 702, 393 );
            dgvFincas.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label2.Location = new Point( 8, 11 );
            label2.Name = "label2";
            label2.Size = new Size( 82, 17 );
            label2.TabIndex = 8;
            label2.Text = "Buscar Finca:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtBuscar.Location = new Point( 8, 31 );
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un nombre";
            txtBuscar.Size = new Size( 361, 25 );
            txtBuscar.TabIndex = 9;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnBuscar.Location = new Point( 375, 29 );
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size( 84, 27 );
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbpDetalle
            // 
            tbpDetalle.Controls.Add( label15 );
            tbpDetalle.Controls.Add( txtProductorID );
            tbpDetalle.Controls.Add( txtUbicacion );
            tbpDetalle.Controls.Add( lblProductorID );
            tbpDetalle.Controls.Add( cmbMunicipio );
            tbpDetalle.Controls.Add( txtFincaID );
            tbpDetalle.Controls.Add( cmbDepartamento );
            tbpDetalle.Controls.Add( lblFincaID );
            tbpDetalle.Controls.Add( cmbProductor );
            tbpDetalle.Controls.Add( label9 );
            tbpDetalle.Controls.Add( txtExtensionTotal );
            tbpDetalle.Controls.Add( label11 );
            tbpDetalle.Controls.Add( txtNombre );
            tbpDetalle.Controls.Add( label12 );
            tbpDetalle.Controls.Add( btnCancelar );
            tbpDetalle.Controls.Add( label13 );
            tbpDetalle.Controls.Add( btnGuardar );
            tbpDetalle.Controls.Add( label14 );
            tbpDetalle.Location = new Point( 4, 24 );
            tbpDetalle.Name = "tbpDetalle";
            tbpDetalle.Padding = new Padding( 3 );
            tbpDetalle.Size = new Size( 822, 502 );
            tbpDetalle.TabIndex = 1;
            tbpDetalle.Text = "Detalle de Finca";
            tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font( "Segoe UI", 9.75F );
            label15.Location = new Point( 360, 117 );
            label15.Name = "label15";
            label15.Size = new Size( 68, 17 );
            label15.TabIndex = 30;
            label15.Text = "Ubicación:";
            // 
            // txtProductorID
            // 
            txtProductorID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtProductorID.Location = new Point( 692, 120 );
            txtProductorID.Name = "txtProductorID";
            txtProductorID.ReadOnly = true;
            txtProductorID.Size = new Size( 100, 25 );
            txtProductorID.TabIndex = 33;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font( "Segoe UI", 9.75F );
            txtUbicacion.Location = new Point( 358, 137 );
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size( 226, 65 );
            txtUbicacion.TabIndex = 29;
            // 
            // lblProductorID
            // 
            lblProductorID.AutoSize = true;
            lblProductorID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblProductorID.Location = new Point( 692, 102 );
            lblProductorID.Name = "lblProductorID";
            lblProductorID.Size = new Size( 81, 17 );
            lblProductorID.TabIndex = 32;
            lblProductorID.Text = "ProductorID:";
            // 
            // cmbMunicipio
            // 
            cmbMunicipio.Font = new Font( "Segoe UI", 9.75F );
            cmbMunicipio.FormattingEnabled = true;
            cmbMunicipio.Location = new Point( 45, 259 );
            cmbMunicipio.Name = "cmbMunicipio";
            cmbMunicipio.Size = new Size( 154, 25 );
            cmbMunicipio.TabIndex = 28;
            // 
            // txtFincaID
            // 
            txtFincaID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtFincaID.Location = new Point( 692, 52 );
            txtFincaID.Name = "txtFincaID";
            txtFincaID.ReadOnly = true;
            txtFincaID.Size = new Size( 100, 25 );
            txtFincaID.TabIndex = 27;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.Font = new Font( "Segoe UI", 9.75F );
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point( 45, 157 );
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size( 154, 25 );
            cmbDepartamento.TabIndex = 27;
            cmbDepartamento.SelectedIndexChanged += cmbDepartamento_SelectedIndexChanged;
            // 
            // lblFincaID
            // 
            lblFincaID.AutoSize = true;
            lblFincaID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblFincaID.Location = new Point( 692, 32 );
            lblFincaID.Name = "lblFincaID";
            lblFincaID.Size = new Size( 52, 17 );
            lblFincaID.TabIndex = 26;
            lblFincaID.Text = "FincaID:";
            // 
            // cmbProductor
            // 
            cmbProductor.Font = new Font( "Segoe UI", 9.75F );
            cmbProductor.FormattingEnabled = true;
            cmbProductor.Location = new Point( 360, 52 );
            cmbProductor.Name = "cmbProductor";
            cmbProductor.Size = new Size( 224, 25 );
            cmbProductor.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font( "Segoe UI", 9.75F );
            label9.Location = new Point( 44, 32 );
            label9.Name = "label9";
            label9.Size = new Size( 60, 17 );
            label9.TabIndex = 17;
            label9.Text = "Nombre:";
            // 
            // txtExtensionTotal
            // 
            txtExtensionTotal.Font = new Font( "Segoe UI", 9.75F );
            txtExtensionTotal.Location = new Point( 358, 259 );
            txtExtensionTotal.MaxLength = 10;
            txtExtensionTotal.Name = "txtExtensionTotal";
            txtExtensionTotal.Size = new Size( 106, 25 );
            txtExtensionTotal.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font( "Segoe UI", 9.75F );
            label11.Location = new Point( 44, 137 );
            label11.Name = "label11";
            label11.Size = new Size( 95, 17 );
            label11.TabIndex = 18;
            label11.Text = "Departamento:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font( "Segoe UI", 9.75F );
            txtNombre.Location = new Point( 45, 52 );
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size( 223, 25 );
            txtNombre.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font( "Segoe UI", 9.75F );
            label12.Location = new Point( 45, 239 );
            label12.Name = "label12";
            label12.Size = new Size( 68, 17 );
            label12.TabIndex = 19;
            label12.Text = "Municipio:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font( "Segoe UI", 9.75F );
            btnCancelar.Location = new Point( 168, 349 );
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size( 100, 30 );
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font( "Segoe UI", 9.75F );
            label13.Location = new Point( 360, 32 );
            label13.Name = "label13";
            label13.Size = new Size( 69, 17 );
            label13.TabIndex = 20;
            label13.Text = "Productor:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font( "Segoe UI", 9.75F );
            btnGuardar.Location = new Point( 45, 349 );
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size( 100, 30 );
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font( "Segoe UI", 9.75F );
            label14.Location = new Point( 358, 239 );
            label14.Name = "label14";
            label14.Size = new Size( 98, 17 );
            label14.TabIndex = 21;
            label14.Text = "Extension Total:";
            // 
            // tbpListaLotes
            // 
            tbpListaLotes.Controls.Add( lblLotesPerPage );
            tbpListaLotes.Controls.Add( comboBox1 );
            tbpListaLotes.Controls.Add( label5 );
            tbpListaLotes.Controls.Add( btnSiguiente2 );
            tbpListaLotes.Controls.Add( btnAnterior2 );
            tbpListaLotes.Controls.Add( lblLotesPages );
            tbpListaLotes.Controls.Add( lblTotalRegistrosLotes );
            tbpListaLotes.Controls.Add( btnEliminarLote );
            tbpListaLotes.Controls.Add( btnEditarLote );
            tbpListaLotes.Controls.Add( btnAgregarLote );
            tbpListaLotes.Controls.Add( dgvLotes );
            tbpListaLotes.Controls.Add( label3 );
            tbpListaLotes.Controls.Add( txtBuscarLote );
            tbpListaLotes.Controls.Add( btnBuscarLote );
            tbpListaLotes.Location = new Point( 4, 24 );
            tbpListaLotes.Name = "tbpListaLotes";
            tbpListaLotes.Padding = new Padding( 3 );
            tbpListaLotes.Size = new Size( 822, 502 );
            tbpListaLotes.TabIndex = 2;
            tbpListaLotes.Text = "Lista de Lotes";
            tbpListaLotes.UseVisualStyleBackColor = true;
            // 
            // lblLotesPerPage
            // 
            lblLotesPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblLotesPerPage.AutoSize = true;
            lblLotesPerPage.Location = new Point( 274, 472 );
            lblLotesPerPage.Name = "lblLotesPerPage";
            lblLotesPerPage.Size = new Size( 114, 15 );
            lblLotesPerPage.TabIndex = 29;
            lblLotesPerPage.Text = "({}) Lotes por página";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange( new object[] { "Auto", "10", "20", "30", "40", "50", "100" } );
            comboBox1.Location = new Point( 206, 467 );
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size( 65, 25 );
            comboBox1.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label5.Location = new Point( 149, 470 );
            label5.Name = "label5";
            label5.Size = new Size( 55, 17 );
            label5.TabIndex = 27;
            label5.Text = "Mostrar";
            // 
            // btnSiguiente2
            // 
            btnSiguiente2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente2.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnSiguiente2.Location = new Point( 618, 467 );
            btnSiguiente2.Name = "btnSiguiente2";
            btnSiguiente2.Size = new Size( 95, 30 );
            btnSiguiente2.TabIndex = 26;
            btnSiguiente2.Text = "Siguiente";
            btnSiguiente2.UseVisualStyleBackColor = true;
            btnSiguiente2.Click += btnSiguiente2_Click;
            // 
            // btnAnterior2
            // 
            btnAnterior2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior2.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAnterior2.Location = new Point( 517, 467 );
            btnAnterior2.Name = "btnAnterior2";
            btnAnterior2.Size = new Size( 95, 30 );
            btnAnterior2.TabIndex = 25;
            btnAnterior2.Text = "Anterior";
            btnAnterior2.UseVisualStyleBackColor = true;
            btnAnterior2.Click += btnAnterior2_Click;
            // 
            // lblLotesPages
            // 
            lblLotesPages.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblLotesPages.AutoSize = true;
            lblLotesPages.Location = new Point( 430, 472 );
            lblLotesPages.Name = "lblLotesPages";
            lblLotesPages.Size = new Size( 81, 15 );
            lblLotesPages.TabIndex = 24;
            lblLotesPages.Text = "Página {} de {}";
            // 
            // lblTotalRegistrosLotes
            // 
            lblTotalRegistrosLotes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistrosLotes.AutoSize = true;
            lblTotalRegistrosLotes.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblTotalRegistrosLotes.Location = new Point( 9, 470 );
            lblTotalRegistrosLotes.Name = "lblTotalRegistrosLotes";
            lblTotalRegistrosLotes.Size = new Size( 83, 17 );
            lblTotalRegistrosLotes.TabIndex = 23;
            lblTotalRegistrosLotes.Text = "Total: {} lotes";
            // 
            // btnEliminarLote
            // 
            btnEliminarLote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarLote.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEliminarLote.Location = new Point( 715, 151 );
            btnEliminarLote.Name = "btnEliminarLote";
            btnEliminarLote.Size = new Size( 100, 30 );
            btnEliminarLote.TabIndex = 22;
            btnEliminarLote.Text = "Eliminar";
            btnEliminarLote.UseVisualStyleBackColor = true;
            // 
            // btnEditarLote
            // 
            btnEditarLote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarLote.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEditarLote.Location = new Point( 715, 104 );
            btnEditarLote.Name = "btnEditarLote";
            btnEditarLote.Size = new Size( 100, 30 );
            btnEditarLote.TabIndex = 21;
            btnEditarLote.Text = "Editar";
            btnEditarLote.UseVisualStyleBackColor = true;
            btnEditarLote.Click += btnEditarLote_Click;
            // 
            // btnAgregarLote
            // 
            btnAgregarLote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarLote.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAgregarLote.Location = new Point( 715, 68 );
            btnAgregarLote.Name = "btnAgregarLote";
            btnAgregarLote.Size = new Size( 100, 30 );
            btnAgregarLote.TabIndex = 20;
            btnAgregarLote.Text = "Nuevo";
            btnAgregarLote.UseVisualStyleBackColor = true;
            btnAgregarLote.Click += btnAgregarLote_Click;
            // 
            // dgvLotes
            // 
            dgvLotes.AllowUserToAddRows = false;
            dgvLotes.AllowUserToDeleteRows = false;
            dgvLotes.AllowUserToResizeColumns = false;
            dgvLotes.AllowUserToResizeRows = false;
            dgvLotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLotes.BorderStyle = BorderStyle.None;
            dgvLotes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLotes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font( "Segoe UI", 9F );
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLotes.EnableHeadersVisualStyles = false;
            dgvLotes.Location = new Point( 7, 68 );
            dgvLotes.MultiSelect = false;
            dgvLotes.Name = "dgvLotes";
            dgvLotes.ReadOnly = true;
            dgvLotes.RowHeadersVisible = false;
            dgvLotes.RowHeadersWidth = 25;
            dgvLotes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLotes.Size = new Size( 702, 393 );
            dgvLotes.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label3.Location = new Point( 7, 15 );
            label3.Name = "label3";
            label3.Size = new Size( 78, 17 );
            label3.TabIndex = 16;
            label3.Text = "Buscar Lote:";
            // 
            // txtBuscarLote
            // 
            txtBuscarLote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarLote.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtBuscarLote.Location = new Point( 7, 35 );
            txtBuscarLote.Name = "txtBuscarLote";
            txtBuscarLote.PlaceholderText = "Ingresar codigo de lote o finca";
            txtBuscarLote.Size = new Size( 361, 25 );
            txtBuscarLote.TabIndex = 17;
            // 
            // btnBuscarLote
            // 
            btnBuscarLote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarLote.AutoSize = true;
            btnBuscarLote.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnBuscarLote.Location = new Point( 374, 33 );
            btnBuscarLote.Name = "btnBuscarLote";
            btnBuscarLote.Size = new Size( 84, 27 );
            btnBuscarLote.TabIndex = 18;
            btnBuscarLote.Text = "Buscar";
            btnBuscarLote.UseVisualStyleBackColor = true;
            btnBuscarLote.Click += btnBuscarLote_Click;
            // 
            // tbpDetalleLote
            // 
            tbpDetalleLote.Controls.Add( btnCancelar2 );
            tbpDetalleLote.Controls.Add( btnGuardarLote );
            tbpDetalleLote.Controls.Add( txtLoteID );
            tbpDetalleLote.Controls.Add( lblLoteID );
            tbpDetalleLote.Controls.Add( txtTipoRiego );
            tbpDetalleLote.Controls.Add( txtTipoSuelo );
            tbpDetalleLote.Controls.Add( txtFincaID_Lote );
            tbpDetalleLote.Controls.Add( txtExtencion );
            tbpDetalleLote.Controls.Add( cmbFincas );
            tbpDetalleLote.Controls.Add( lblFincaID_Lote );
            tbpDetalleLote.Controls.Add( label17 );
            tbpDetalleLote.Controls.Add( label16 );
            tbpDetalleLote.Controls.Add( label10 );
            tbpDetalleLote.Controls.Add( label8 );
            tbpDetalleLote.Location = new Point( 4, 24 );
            tbpDetalleLote.Name = "tbpDetalleLote";
            tbpDetalleLote.Padding = new Padding( 3 );
            tbpDetalleLote.Size = new Size( 822, 502 );
            tbpDetalleLote.TabIndex = 3;
            tbpDetalleLote.Text = "Detalle de Lote";
            tbpDetalleLote.UseVisualStyleBackColor = true;
            // 
            // btnCancelar2
            // 
            btnCancelar2.Font = new Font( "Segoe UI", 9.75F );
            btnCancelar2.Location = new Point( 200, 218 );
            btnCancelar2.Name = "btnCancelar2";
            btnCancelar2.Size = new Size( 100, 30 );
            btnCancelar2.TabIndex = 25;
            btnCancelar2.Text = "Cancelar";
            btnCancelar2.UseVisualStyleBackColor = true;
            btnCancelar2.Click += btnCancelar2_Click;
            // 
            // btnGuardarLote
            // 
            btnGuardarLote.Font = new Font( "Segoe UI", 9.75F );
            btnGuardarLote.Location = new Point( 77, 218 );
            btnGuardarLote.Name = "btnGuardarLote";
            btnGuardarLote.Size = new Size( 100, 30 );
            btnGuardarLote.TabIndex = 24;
            btnGuardarLote.Text = "Guardar";
            btnGuardarLote.UseVisualStyleBackColor = true;
            btnGuardarLote.Click += btnGuardarLote_Click;
            // 
            // txtLoteID
            // 
            txtLoteID.Location = new Point( 602, 146 );
            txtLoteID.Name = "txtLoteID";
            txtLoteID.ReadOnly = true;
            txtLoteID.Size = new Size( 88, 23 );
            txtLoteID.TabIndex = 13;
            txtLoteID.TabStop = false;
            // 
            // lblLoteID
            // 
            lblLoteID.AutoSize = true;
            lblLoteID.Location = new Point( 602, 128 );
            lblLoteID.Name = "lblLoteID";
            lblLoteID.Size = new Size( 44, 15 );
            lblLoteID.TabIndex = 12;
            lblLoteID.Text = "LoteID:";
            // 
            // txtTipoRiego
            // 
            txtTipoRiego.Location = new Point( 275, 146 );
            txtTipoRiego.Name = "txtTipoRiego";
            txtTipoRiego.Size = new Size( 136, 23 );
            txtTipoRiego.TabIndex = 11;
            // 
            // txtTipoSuelo
            // 
            txtTipoSuelo.Location = new Point( 275, 60 );
            txtTipoSuelo.Name = "txtTipoSuelo";
            txtTipoSuelo.Size = new Size( 136, 23 );
            txtTipoSuelo.TabIndex = 10;
            // 
            // txtFincaID_Lote
            // 
            txtFincaID_Lote.Location = new Point( 602, 60 );
            txtFincaID_Lote.Name = "txtFincaID_Lote";
            txtFincaID_Lote.ReadOnly = true;
            txtFincaID_Lote.Size = new Size( 88, 23 );
            txtFincaID_Lote.TabIndex = 9;
            txtFincaID_Lote.TabStop = false;
            // 
            // txtExtencion
            // 
            txtExtencion.Location = new Point( 44, 146 );
            txtExtencion.Name = "txtExtencion";
            txtExtencion.Size = new Size( 100, 23 );
            txtExtencion.TabIndex = 8;
            // 
            // cmbFincas
            // 
            cmbFincas.FormattingEnabled = true;
            cmbFincas.Location = new Point( 44, 60 );
            cmbFincas.Name = "cmbFincas";
            cmbFincas.Size = new Size( 121, 23 );
            cmbFincas.TabIndex = 5;
            // 
            // lblFincaID_Lote
            // 
            lblFincaID_Lote.AutoSize = true;
            lblFincaID_Lote.Location = new Point( 602, 42 );
            lblFincaID_Lote.Name = "lblFincaID_Lote";
            lblFincaID_Lote.Size = new Size( 49, 15 );
            lblFincaID_Lote.TabIndex = 4;
            lblFincaID_Lote.Text = "FincaID:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point( 275, 128 );
            label17.Name = "label17";
            label17.Size = new Size( 80, 15 );
            label17.TabIndex = 3;
            label17.Text = "Tipo de Riego";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point( 44, 128 );
            label16.Name = "label16";
            label16.Size = new Size( 60, 15 );
            label16.TabIndex = 2;
            label16.Text = "Extensión:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point( 275, 42 );
            label10.Name = "label10";
            label10.Size = new Size( 82, 15 );
            label10.TabIndex = 1;
            label10.Text = "Tipo de Suelo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point( 44, 42 );
            label8.Name = "label8";
            label8.Size = new Size( 38, 15 );
            label8.TabIndex = 0;
            label8.Text = "Finca:";
            // 
            // FincasView
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 830, 580 );
            Controls.Add( tabControl );
            Controls.Add( panelTop );
            FormBorderStyle = FormBorderStyle.None;
            Name = "FincasView";
            Text = "FincasForm";
            panelTop.ResumeLayout( false );
            panelTop.PerformLayout();
            tabControl.ResumeLayout( false );
            tbpLista.ResumeLayout( false );
            tbpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFincas).EndInit();
            tbpDetalle.ResumeLayout( false );
            tbpDetalle.PerformLayout();
            tbpListaLotes.ResumeLayout( false );
            tbpListaLotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).EndInit();
            tbpDetalleLote.ResumeLayout( false );
            tbpDetalleLote.PerformLayout();
            ResumeLayout( false );
        }

        #endregion

        private Panel panelTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tbpLista;
        private TabPage tbpDetalle;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvFincas;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtFincaID;
        private Label lblFincaID;
        private TextBox txtProductorID;
        private Label lblProductorID;
        private Label label15;
        private TextBox txtUbicacion;
        private ComboBox cmbMunicipio;
        private ComboBox cmbDepartamento;
        private ComboBox cmbProductor;
        private Label label9;
        private TextBox txtExtensionTotal;
        private Label label11;
        private TextBox txtNombre;
        private Label label12;
        private Button btnCancelar;
        private Label label13;
        private Button btnGuardar;
        private Label label14;
        private Button btnNuevoLote;
        private TabPage tbpListaLotes;
        private TabPage tbpDetalleLote;
        private Button btnEliminarLote;
        private Button btnEditarLote;
        private Button btnAgregarLote;
        private DataGridView dgvLotes;
        private Label label3;
        private TextBox txtBuscarLote;
        private Button btnBuscarLote;
        private Label lblRecordsPerPage;
        private ComboBox cmbRecordsPerPage;
        private Label label6;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblPaginas;
        private Label lblTotalRegistros;
        private Label lblLotesPerPage;
        private ComboBox comboBox1;
        private Label label5;
        private Button btnSiguiente2;
        private Button btnAnterior2;
        private Label lblLotesPages;
        private Label lblTotalRegistrosLotes;
        private ComboBox cmbFincas;
        private Label lblFincaID_Lote;
        private Label label17;
        private Label label16;
        private Label label10;
        private Label label8;
        private TextBox txtExtencion;
        private TextBox txtLoteID;
        private Label lblLoteID;
        private TextBox txtTipoRiego;
        private TextBox txtTipoSuelo;
        private TextBox txtFincaID_Lote;
        private Button btnCancelar2;
        private Button btnGuardarLote;
    }
}