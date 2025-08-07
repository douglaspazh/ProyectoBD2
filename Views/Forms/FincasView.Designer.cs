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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            tabControl = new TabControl();
            tbpLista = new TabPage();
            button1 = new Button();
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
            tbpDetalleLote = new TabPage();
            btnEliminarLote = new Button();
            btnEditarLote = new Button();
            btnAgregarLote = new Button();
            dgvLotes = new DataGridView();
            label3 = new Label();
            txtBuscarLote = new TextBox();
            btnBuscarLote = new Button();
            panelTop.SuspendLayout();
            tabControl.SuspendLayout();
            tbpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFincas).BeginInit();
            tbpDetalle.SuspendLayout();
            tbpListaLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).BeginInit();
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
            tbpLista.Controls.Add( button1 );
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            button1.Location = new Point( 716, 11 );
            button1.Name = "button1";
            button1.Size = new Size( 100, 30 );
            button1.TabIndex = 15;
            button1.Text = "Nuevo Lote";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEliminar.Location = new Point( 716, 147 );
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size( 100, 30 );
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEditar.Location = new Point( 716, 100 );
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size( 100, 30 );
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAgregar.Location = new Point( 716, 64 );
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size( 100, 30 );
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font( "Segoe UI", 9F );
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFincas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dgvFincas.Size = new Size( 702, 419 );
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
            // tbpDetalleLote
            // 
            tbpDetalleLote.Location = new Point( 4, 24 );
            tbpDetalleLote.Name = "tbpDetalleLote";
            tbpDetalleLote.Padding = new Padding( 3 );
            tbpDetalleLote.Size = new Size( 822, 502 );
            tbpDetalleLote.TabIndex = 3;
            tbpDetalleLote.Text = "Detalle de Lote";
            tbpDetalleLote.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font( "Segoe UI", 9F );
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dgvLotes.Size = new Size( 702, 419 );
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
        private Button button1;
        private TabPage tbpListaLotes;
        private TabPage tbpDetalleLote;
        private Button btnEliminarLote;
        private Button btnEditarLote;
        private Button btnAgregarLote;
        private DataGridView dgvLotes;
        private Label label3;
        private TextBox txtBuscarLote;
        private Button btnBuscarLote;
    }
}