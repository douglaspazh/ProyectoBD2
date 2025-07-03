namespace ProyectoBD2.UI.Forms
{
    partial class ProductoresForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvProductores = new DataGridView();
            productorBindingSource = new BindingSource( components );
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
            tbpDetalle = new TabPage();
            txtProductorID = new TextBox();
            lblProductorID = new Label();
            txtFechaRegistro = new TextBox();
            lblFechaRegistro = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvProductores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productorBindingSource).BeginInit();
            panelTop.SuspendLayout();
            tabControl.SuspendLayout();
            tbpLista.SuspendLayout();
            tbpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font( "Segoe UI", 9F );
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductores.EnableHeadersVisualStyles = false;
            dgvProductores.Location = new Point( 8, 67 );
            dgvProductores.MultiSelect = false;
            dgvProductores.Name = "dgvProductores";
            dgvProductores.ReadOnly = true;
            dgvProductores.RowHeadersVisible = false;
            dgvProductores.RowHeadersWidth = 25;
            dgvProductores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductores.Size = new Size( 692, 419 );
            dgvProductores.TabIndex = 0;
            // 
            // productorBindingSource
            // 
            productorBindingSource.DataSource = typeof( Models.Productor );
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAgregar.Location = new Point( 706, 67 );
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size( 95, 30 );
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEditar.Location = new Point( 706, 103 );
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size( 95, 30 );
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEliminar.Location = new Point( 706, 139 );
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size( 95, 30 );
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0 );
            label1.Location = new Point( 48, 15 );
            label1.Name = "label1";
            label1.Size = new Size( 101, 17 );
            label1.TabIndex = 4;
            label1.Text = "PRODUCTORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label2.Location = new Point( 8, 11 );
            label2.Name = "label2";
            label2.Size = new Size( 112, 17 );
            label2.TabIndex = 5;
            label2.Text = "Buscar productor:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtBuscar.Location = new Point( 8, 31 );
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size( 361, 25 );
            txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnBuscar.Location = new Point( 375, 29 );
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size( 84, 27 );
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
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
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
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
            // tabControl
            // 
            tabControl.Controls.Add( tbpLista );
            tabControl.Controls.Add( tbpDetalle );
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point( 0, 50 );
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size( 830, 531 );
            tabControl.TabIndex = 9;
            // 
            // tbpLista
            // 
            tbpLista.Controls.Add( label2 );
            tbpLista.Controls.Add( txtBuscar );
            tbpLista.Controls.Add( btnEliminar );
            tbpLista.Controls.Add( btnBuscar );
            tbpLista.Controls.Add( btnEditar );
            tbpLista.Controls.Add( dgvProductores );
            tbpLista.Controls.Add( btnAgregar );
            tbpLista.Location = new Point( 4, 24 );
            tbpLista.Name = "tbpLista";
            tbpLista.Padding = new Padding( 3 );
            tbpLista.Size = new Size( 822, 503 );
            tbpLista.TabIndex = 0;
            tbpLista.Text = "Lista de productores";
            tbpLista.UseVisualStyleBackColor = true;
            // 
            // tbpDetalle
            // 
            tbpDetalle.Controls.Add( txtProductorID );
            tbpDetalle.Controls.Add( lblProductorID );
            tbpDetalle.Controls.Add( txtFechaRegistro );
            tbpDetalle.Controls.Add( lblFechaRegistro );
            tbpDetalle.Controls.Add( pictureBox );
            tbpDetalle.Controls.Add( btnCancelar );
            tbpDetalle.Controls.Add( btnGuardar );
            tbpDetalle.Controls.Add( cmbEstado );
            tbpDetalle.Controls.Add( label4 );
            tbpDetalle.Controls.Add( txtEmail );
            tbpDetalle.Controls.Add( label3 );
            tbpDetalle.Controls.Add( txtTelefono );
            tbpDetalle.Controls.Add( label5 );
            tbpDetalle.Controls.Add( txtNombre );
            tbpDetalle.Controls.Add( lblNombre );
            tbpDetalle.Location = new Point( 4, 24 );
            tbpDetalle.Name = "tbpDetalle";
            tbpDetalle.Padding = new Padding( 3 );
            tbpDetalle.Size = new Size( 822, 503 );
            tbpDetalle.TabIndex = 1;
            tbpDetalle.Text = "Detalle de productor";
            tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // txtProductorID
            // 
            txtProductorID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtProductorID.Location = new Point( 556, 49 );
            txtProductorID.Name = "txtProductorID";
            txtProductorID.ReadOnly = true;
            txtProductorID.Size = new Size( 100, 25 );
            txtProductorID.TabIndex = 25;
            // 
            // lblProductorID
            // 
            lblProductorID.AutoSize = true;
            lblProductorID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblProductorID.Location = new Point( 556, 29 );
            lblProductorID.Name = "lblProductorID";
            lblProductorID.Size = new Size( 81, 17 );
            lblProductorID.TabIndex = 24;
            lblProductorID.Text = "ProductorID:";
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtFechaRegistro.Location = new Point( 556, 245 );
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.ReadOnly = true;
            txtFechaRegistro.Size = new Size( 144, 25 );
            txtFechaRegistro.TabIndex = 23;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblFechaRegistro.Location = new Point( 556, 225 );
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size( 116, 17 );
            lblFechaRegistro.TabIndex = 22;
            lblFechaRegistro.Text = "Fecha de Registro:";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point( 31, 29 );
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size( 125, 125 );
            pictureBox.TabIndex = 21;
            pictureBox.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font( "Segoe UI", 9.75F );
            btnCancelar.Location = new Point( 285, 295 );
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size( 100, 30 );
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font( "Segoe UI", 9.75F );
            btnGuardar.Location = new Point( 179, 295 );
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size( 100, 30 );
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font( "Segoe UI", 9.75F );
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange( new object[] { "Activo", "Inactivo" } );
            cmbEstado.Location = new Point( 180, 245 );
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size( 121, 25 );
            cmbEstado.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font( "Segoe UI", 9.75F );
            label4.Location = new Point( 180, 225 );
            label4.Name = "label4";
            label4.Size = new Size( 51, 17 );
            label4.TabIndex = 17;
            label4.Text = "Estado:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font( "Segoe UI", 9.75F );
            txtEmail.Location = new Point( 179, 179 );
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size( 221, 25 );
            txtEmail.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font( "Segoe UI", 9.75F );
            label3.Location = new Point( 179, 159 );
            label3.Name = "label3";
            label3.Size = new Size( 52, 17 );
            label3.TabIndex = 15;
            label3.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font( "Segoe UI", 9.75F );
            txtTelefono.Location = new Point( 180, 113 );
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size( 142, 25 );
            txtTelefono.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font( "Segoe UI", 9.75F );
            label5.Location = new Point( 179, 93 );
            label5.Name = "label5";
            label5.Size = new Size( 61, 17 );
            label5.TabIndex = 13;
            label5.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font( "Segoe UI", 9.75F );
            txtNombre.Location = new Point( 179, 49 );
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size( 308, 25 );
            txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font( "Segoe UI", 9.75F );
            lblNombre.Location = new Point( 179, 29 );
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size( 60, 17 );
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre:";
            // 
            // ProductoresForm
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 830, 581 );
            Controls.Add( tabControl );
            Controls.Add( panelTop );
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductoresForm";
            Text = "ProductoresForm";
            ((System.ComponentModel.ISupportInitialize)dgvProductores).EndInit();
            ((System.ComponentModel.ISupportInitialize)productorBindingSource).EndInit();
            panelTop.ResumeLayout( false );
            panelTop.PerformLayout();
            tabControl.ResumeLayout( false );
            tbpLista.ResumeLayout( false );
            tbpLista.PerformLayout();
            tbpDetalle.ResumeLayout( false );
            tbpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private DataGridView dgvProductores;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Panel panelTop;
        private TabControl tabControl;
        private TabPage tbpDetalle;
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
        private TextBox txtFechaRegistro;
        private Label lblFechaRegistro;
        private Label lblProductorID;
        private TextBox txtProductorID;
        private BindingSource productorBindingSource;
        private BindingSource productorBindingSource1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}