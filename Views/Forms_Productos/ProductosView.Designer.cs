namespace ProyectoBD2.Views.Forms
{
    partial class ProductosView
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelTop = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            tabControl = new TabControl();
            tbpLista = new TabPage();
            btnNuevaCat = new Button();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label6 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            btnEditar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            tbpDetalle = new TabPage();
            txtCategoriaID = new TextBox();
            lblCategoriaID = new Label();
            txtProductoID = new TextBox();
            lblProductoID = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbCategorias = new ComboBox();
            label5 = new Label();
            txtUnidad = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            tbpNuevaCategoria = new TabPage();
            btnCancelarCat = new Button();
            btnGuardarCategoria = new Button();
            txtObservaciones = new TextBox();
            label8 = new Label();
            txtNombreCategoria = new TextBox();
            label7 = new Label();
            panelTop.SuspendLayout();
            tabControl.SuspendLayout();
            tbpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tbpDetalle.SuspendLayout();
            tbpNuevaCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
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
            label1.Size = new Size( 86, 17 );
            label1.TabIndex = 4;
            label1.Text = "PRODUCTOS";
            // 
            // panelTop
            // 
            panelTop.Controls.Add( iconButton2 );
            panelTop.Controls.Add( btnCerrar );
            panelTop.Controls.Add( iconButton1 );
            panelTop.Controls.Add( label1 );
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point( 0, 0 );
            panelTop.Name = "panelTop";
            panelTop.Size = new Size( 862, 50 );
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
            iconButton2.Location = new Point( 814, 6 );
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size( 36, 36 );
            iconButton2.TabIndex = 10;
            iconButton2.UseVisualStyleBackColor = true;
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
            btnCerrar.Location = new Point( 1444, 6 );
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size( 36, 36 );
            btnCerrar.TabIndex = 7;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add( tbpLista );
            tabControl.Controls.Add( tbpDetalle );
            tabControl.Controls.Add( tbpNuevaCategoria );
            tabControl.Location = new Point( 0, 50 );
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size( 859, 531 );
            tabControl.TabIndex = 10;
            // 
            // tbpLista
            // 
            tbpLista.Controls.Add( btnNuevaCat );
            tbpLista.Controls.Add( lblRecordsPerPage );
            tbpLista.Controls.Add( cmbRecordsPerPage );
            tbpLista.Controls.Add( label6 );
            tbpLista.Controls.Add( btnSiguiente );
            tbpLista.Controls.Add( btnAnterior );
            tbpLista.Controls.Add( lblPaginas );
            tbpLista.Controls.Add( lblTotalRegistros );
            tbpLista.Controls.Add( btnEditar );
            tbpLista.Controls.Add( btnAgregar );
            tbpLista.Controls.Add( label2 );
            tbpLista.Controls.Add( txtBuscar );
            tbpLista.Controls.Add( btnBuscar );
            tbpLista.Controls.Add( dgvProductos );
            tbpLista.Location = new Point( 4, 24 );
            tbpLista.Name = "tbpLista";
            tbpLista.Padding = new Padding( 3 );
            tbpLista.Size = new Size( 851, 503 );
            tbpLista.TabIndex = 1;
            tbpLista.Text = "Lista de Productos";
            tbpLista.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCat
            // 
            btnNuevaCat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevaCat.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnNuevaCat.Location = new Point( 721, 6 );
            btnNuevaCat.Name = "btnNuevaCat";
            btnNuevaCat.Size = new Size( 124, 32 );
            btnNuevaCat.TabIndex = 22;
            btnNuevaCat.Text = "Nueva Categoría";
            btnNuevaCat.UseVisualStyleBackColor = true;
            btnNuevaCat.Click += btnNuevaCat_Click;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point( 282, 475 );
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size( 140, 15 );
            lblRecordsPerPage.TabIndex = 21;
            lblRecordsPerPage.Text = "({}) Productos por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange( new object[] { "Auto", "10", "20", "30", "40", "50", "100" } );
            cmbRecordsPerPage.Location = new Point( 214, 471 );
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size( 65, 25 );
            cmbRecordsPerPage.TabIndex = 20;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label6.Location = new Point( 157, 473 );
            label6.Name = "label6";
            label6.Size = new Size( 55, 17 );
            label6.TabIndex = 19;
            label6.Text = "Mostrar";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnSiguiente.Location = new Point( 644, 466 );
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size( 95, 30 );
            btnSiguiente.TabIndex = 18;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAnterior.Location = new Point( 543, 466 );
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size( 95, 30 );
            btnAnterior.TabIndex = 17;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point( 456, 473 );
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size( 81, 15 );
            lblPaginas.TabIndex = 16;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblTotalRegistros.Location = new Point( 8, 473 );
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size( 115, 17 );
            lblTotalRegistros.TabIndex = 15;
            lblTotalRegistros.Text = "Total: {} productos";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEditar.Location = new Point( 745, 105 );
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size( 100, 32 );
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAgregar.Location = new Point( 745, 54 );
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size( 100, 32 );
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label2.Location = new Point( 8, 3 );
            label2.Name = "label2";
            label2.Size = new Size( 107, 17 );
            label2.TabIndex = 8;
            label2.Text = "Buscar producto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtBuscar.Location = new Point( 8, 23 );
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un nombre";
            txtBuscar.Size = new Size( 322, 25 );
            txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnBuscar.Location = new Point( 336, 18 );
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size( 84, 30 );
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font( "Segoe UI", 9F );
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point( 8, 54 );
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 25;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size( 731, 406 );
            dgvProductos.TabIndex = 1;
            // 
            // tbpDetalle
            // 
            tbpDetalle.Controls.Add( txtCategoriaID );
            tbpDetalle.Controls.Add( lblCategoriaID );
            tbpDetalle.Controls.Add( txtProductoID );
            tbpDetalle.Controls.Add( lblProductoID );
            tbpDetalle.Controls.Add( btnCancelar );
            tbpDetalle.Controls.Add( btnGuardar );
            tbpDetalle.Controls.Add( cmbCategorias );
            tbpDetalle.Controls.Add( label5 );
            tbpDetalle.Controls.Add( txtUnidad );
            tbpDetalle.Controls.Add( label4 );
            tbpDetalle.Controls.Add( txtNombre );
            tbpDetalle.Controls.Add( label3 );
            tbpDetalle.Location = new Point( 4, 24 );
            tbpDetalle.Name = "tbpDetalle";
            tbpDetalle.Padding = new Padding( 3 );
            tbpDetalle.Size = new Size( 851, 503 );
            tbpDetalle.TabIndex = 2;
            tbpDetalle.Text = "Detalle de Producto";
            tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // txtCategoriaID
            // 
            txtCategoriaID.Location = new Point( 546, 62 );
            txtCategoriaID.Name = "txtCategoriaID";
            txtCategoriaID.ReadOnly = true;
            txtCategoriaID.Size = new Size( 137, 23 );
            txtCategoriaID.TabIndex = 26;
            // 
            // lblCategoriaID
            // 
            lblCategoriaID.AutoSize = true;
            lblCategoriaID.Location = new Point( 546, 44 );
            lblCategoriaID.Name = "lblCategoriaID";
            lblCategoriaID.Size = new Size( 72, 15 );
            lblCategoriaID.TabIndex = 25;
            lblCategoriaID.Text = "CategoriaID:";
            // 
            // txtProductoID
            // 
            txtProductoID.Location = new Point( 297, 62 );
            txtProductoID.MaxLength = 12;
            txtProductoID.Name = "txtProductoID";
            txtProductoID.Size = new Size( 137, 23 );
            txtProductoID.TabIndex = 24;
            // 
            // lblProductoID
            // 
            lblProductoID.AutoSize = true;
            lblProductoID.Location = new Point( 297, 44 );
            lblProductoID.Name = "lblProductoID";
            lblProductoID.Size = new Size( 70, 15 );
            lblProductoID.TabIndex = 23;
            lblProductoID.Text = "ProductoID:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font( "Segoe UI", 9.75F );
            btnCancelar.Location = new Point( 161, 291 );
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size( 100, 30 );
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font( "Segoe UI", 9.75F );
            btnGuardar.Location = new Point( 44, 291 );
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size( 100, 30 );
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.Font = new Font( "Segoe UI", 9.75F );
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point( 44, 228 );
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size( 142, 25 );
            cmbCategorias.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label5.Location = new Point( 44, 208 );
            label5.Name = "label5";
            label5.Size = new Size( 68, 17 );
            label5.TabIndex = 16;
            label5.Text = "Categoría:";
            // 
            // txtUnidad
            // 
            txtUnidad.Font = new Font( "Segoe UI", 9.75F );
            txtUnidad.Location = new Point( 44, 143 );
            txtUnidad.MaxLength = 25;
            txtUnidad.Name = "txtUnidad";
            txtUnidad.PlaceholderText = "kg, lb, oz, etc";
            txtUnidad.Size = new Size( 157, 25 );
            txtUnidad.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label4.Location = new Point( 44, 123 );
            label4.Name = "label4";
            label4.Size = new Size( 142, 17 );
            label4.TabIndex = 14;
            label4.Text = "Contenido por Unidad:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font( "Segoe UI", 9.75F );
            txtNombre.Location = new Point( 44, 62 );
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size( 180, 25 );
            txtNombre.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label3.Location = new Point( 44, 42 );
            label3.Name = "label3";
            label3.Size = new Size( 60, 17 );
            label3.TabIndex = 9;
            label3.Text = "Nombre:";
            // 
            // tbpNuevaCategoria
            // 
            tbpNuevaCategoria.Controls.Add( btnCancelarCat );
            tbpNuevaCategoria.Controls.Add( btnGuardarCategoria );
            tbpNuevaCategoria.Controls.Add( txtObservaciones );
            tbpNuevaCategoria.Controls.Add( label8 );
            tbpNuevaCategoria.Controls.Add( txtNombreCategoria );
            tbpNuevaCategoria.Controls.Add( label7 );
            tbpNuevaCategoria.Location = new Point( 4, 24 );
            tbpNuevaCategoria.Name = "tbpNuevaCategoria";
            tbpNuevaCategoria.Padding = new Padding( 3 );
            tbpNuevaCategoria.Size = new Size( 851, 503 );
            tbpNuevaCategoria.TabIndex = 3;
            tbpNuevaCategoria.Text = "Nueva Categoría";
            tbpNuevaCategoria.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCat
            // 
            btnCancelarCat.Font = new Font( "Segoe UI", 9.75F );
            btnCancelarCat.Location = new Point( 161, 263 );
            btnCancelarCat.Name = "btnCancelarCat";
            btnCancelarCat.Size = new Size( 100, 30 );
            btnCancelarCat.TabIndex = 24;
            btnCancelarCat.Text = "Cancelar";
            btnCancelarCat.UseVisualStyleBackColor = true;
            btnCancelarCat.Click += btnCancelarCat_Click;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.Font = new Font( "Segoe UI", 9.75F );
            btnGuardarCategoria.Location = new Point( 44, 263 );
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size( 100, 30 );
            btnGuardarCategoria.TabIndex = 23;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = true;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font( "Segoe UI", 9.75F );
            txtObservaciones.Location = new Point( 44, 150 );
            txtObservaciones.MaxLength = 25;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size( 210, 71 );
            txtObservaciones.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label8.Location = new Point( 44, 130 );
            label8.Name = "label8";
            label8.Size = new Size( 97, 17 );
            label8.TabIndex = 16;
            label8.Text = "Observaciones:";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Font = new Font( "Segoe UI", 9.75F );
            txtNombreCategoria.Location = new Point( 44, 62 );
            txtNombreCategoria.MaxLength = 25;
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size( 210, 25 );
            txtNombreCategoria.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label7.Location = new Point( 44, 42 );
            label7.Name = "label7";
            label7.Size = new Size( 60, 17 );
            label7.TabIndex = 14;
            label7.Text = "Nombre:";
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 862, 588 );
            Controls.Add( tabControl );
            Controls.Add( panelTop );
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductosView";
            Text = "ProductosView";
            panelTop.ResumeLayout( false );
            panelTop.PerformLayout();
            tabControl.ResumeLayout( false );
            tbpLista.ResumeLayout( false );
            tbpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tbpDetalle.ResumeLayout( false );
            tbpDetalle.PerformLayout();
            tbpNuevaCategoria.ResumeLayout( false );
            tbpNuevaCategoria.PerformLayout();
            ResumeLayout( false );
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Panel panelTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TabControl tabControl;
        private TabPage tbpLista;
        private DataGridView dgvProductos;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label lblRecordsPerPage;
        private ComboBox cmbRecordsPerPage;
        private Label label6;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblPaginas;
        private Label lblTotalRegistros;
        private TabPage tbpDetalle;
        private Button btnNuevaCat;
        private Label label3;
        private TabPage tbpNuevaCategoria;
        private Label label5;
        private TextBox txtUnidad;
        private Label label4;
        private TextBox txtNombre;
        private ComboBox cmbCategorias;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNombreCategoria;
        private Label label7;
        private TextBox txtObservaciones;
        private Label label8;
        private Button btnCancelarCat;
        private Button btnGuardarCategoria;
        private TextBox txtCategoriaID;
        private Label lblCategoriaID;
        private TextBox txtProductoID;
        private Label lblProductoID;
    }
}