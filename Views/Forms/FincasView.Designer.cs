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
            panelTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            tabControl = new TabControl();
            tbpLista = new TabPage();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvFincas = new DataGridView();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            tbpDetalle = new TabPage();
            txtFechaRegistro = new TextBox();
            lblFechaRegistro = new Label();
            txtExtensionTotal = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtProductorID = new TextBox();
            lblProductorID = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtFincaID = new TextBox();
            lblFincaID = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            pictureBox = new PictureBox();
            cmbProductorNombre = new ComboBox();
            panelTop.SuspendLayout();
            tabControl.SuspendLayout();
            tbpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFincas).BeginInit();
            tbpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point( 0, 50 );
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size( 830, 530 );
            tabControl.TabIndex = 10;
            // 
            // tbpLista
            // 
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
            tbpLista.Text = "Lista de fincas";
            tbpLista.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEliminar.Location = new Point( 706, 134 );
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size( 95, 30 );
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnEditar.Location = new Point( 706, 98 );
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size( 95, 30 );
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnAgregar.Location = new Point( 706, 62 );
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size( 95, 30 );
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
            dgvFincas.Size = new Size( 692, 419 );
            dgvFincas.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            label2.Location = new Point( 8, 11 );
            label2.Name = "label2";
            label2.Size = new Size( 80, 17 );
            label2.TabIndex = 8;
            label2.Text = "Buscar finca:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtBuscar.Location = new Point( 8, 31 );
            txtBuscar.Name = "txtBuscar";
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
            tbpDetalle.Controls.Add( cmbProductorNombre );
            tbpDetalle.Controls.Add( txtFechaRegistro );
            tbpDetalle.Controls.Add( lblFechaRegistro );
            tbpDetalle.Controls.Add( txtExtensionTotal );
            tbpDetalle.Controls.Add( label5 );
            tbpDetalle.Controls.Add( txtDireccion );
            tbpDetalle.Controls.Add( label4 );
            tbpDetalle.Controls.Add( txtProductorID );
            tbpDetalle.Controls.Add( lblProductorID );
            tbpDetalle.Controls.Add( label3 );
            tbpDetalle.Controls.Add( btnCancelar );
            tbpDetalle.Controls.Add( btnGuardar );
            tbpDetalle.Controls.Add( txtFincaID );
            tbpDetalle.Controls.Add( lblFincaID );
            tbpDetalle.Controls.Add( txtNombre );
            tbpDetalle.Controls.Add( lblNombre );
            tbpDetalle.Controls.Add( pictureBox );
            tbpDetalle.Location = new Point( 4, 24 );
            tbpDetalle.Name = "tbpDetalle";
            tbpDetalle.Padding = new Padding( 3 );
            tbpDetalle.Size = new Size( 822, 502 );
            tbpDetalle.TabIndex = 1;
            tbpDetalle.Text = "Detalle de finca";
            tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtFechaRegistro.Location = new Point( 566, 256 );
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.ReadOnly = true;
            txtFechaRegistro.Size = new Size( 134, 25 );
            txtFechaRegistro.TabIndex = 39;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblFechaRegistro.Location = new Point( 566, 236 );
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size( 116, 17 );
            lblFechaRegistro.TabIndex = 38;
            lblFechaRegistro.Text = "Fecha de Registro:";
            // 
            // txtExtensionTotal
            // 
            txtExtensionTotal.Font = new Font( "Segoe UI", 9.75F );
            txtExtensionTotal.Location = new Point( 183, 254 );
            txtExtensionTotal.Name = "txtExtensionTotal";
            txtExtensionTotal.Size = new Size( 124, 25 );
            txtExtensionTotal.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font( "Segoe UI", 9.75F );
            label5.Location = new Point( 183, 236 );
            label5.Name = "label5";
            label5.Size = new Size( 96, 17 );
            label5.TabIndex = 36;
            label5.Text = "Extensión total:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font( "Segoe UI", 9.75F );
            txtDireccion.Location = new Point( 183, 186 );
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size( 308, 25 );
            txtDireccion.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font( "Segoe UI", 9.75F );
            label4.Location = new Point( 183, 168 );
            label4.Name = "label4";
            label4.Size = new Size( 65, 17 );
            label4.TabIndex = 34;
            label4.Text = "Dirección:";
            // 
            // txtProductorID
            // 
            txtProductorID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtProductorID.Location = new Point( 566, 118 );
            txtProductorID.Name = "txtProductorID";
            txtProductorID.ReadOnly = true;
            txtProductorID.Size = new Size( 100, 25 );
            txtProductorID.TabIndex = 33;
            // 
            // lblProductorID
            // 
            lblProductorID.AutoSize = true;
            lblProductorID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblProductorID.Location = new Point( 566, 100 );
            lblProductorID.Name = "lblProductorID";
            lblProductorID.Size = new Size( 81, 17 );
            lblProductorID.TabIndex = 32;
            lblProductorID.Text = "ProductorID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font( "Segoe UI", 9.75F );
            label3.Location = new Point( 183, 102 );
            label3.Name = "label3";
            label3.Size = new Size( 69, 17 );
            label3.TabIndex = 30;
            label3.Text = "Productor:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font( "Segoe UI", 9.75F );
            btnCancelar.Location = new Point( 289, 312 );
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size( 100, 30 );
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font( "Segoe UI", 9.75F );
            btnGuardar.Location = new Point( 183, 312 );
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size( 100, 30 );
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtFincaID
            // 
            txtFincaID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            txtFincaID.Location = new Point( 566, 50 );
            txtFincaID.Name = "txtFincaID";
            txtFincaID.ReadOnly = true;
            txtFincaID.Size = new Size( 100, 25 );
            txtFincaID.TabIndex = 27;
            // 
            // lblFincaID
            // 
            lblFincaID.AutoSize = true;
            lblFincaID.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            lblFincaID.Location = new Point( 566, 30 );
            lblFincaID.Name = "lblFincaID";
            lblFincaID.Size = new Size( 52, 17 );
            lblFincaID.TabIndex = 26;
            lblFincaID.Text = "FincaID:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font( "Segoe UI", 9.75F );
            txtNombre.Location = new Point( 183, 50 );
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size( 308, 25 );
            txtNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font( "Segoe UI", 9.75F );
            lblNombre.Location = new Point( 183, 30 );
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size( 60, 17 );
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre:";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point( 30, 30 );
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size( 125, 125 );
            pictureBox.TabIndex = 22;
            pictureBox.TabStop = false;
            // 
            // cmbProductorNombre
            // 
            cmbProductorNombre.FormattingEnabled = true;
            cmbProductorNombre.Location = new Point( 183, 122 );
            cmbProductorNombre.Name = "cmbProductorNombre";
            cmbProductorNombre.Size = new Size( 308, 23 );
            cmbProductorNombre.TabIndex = 40;
            // 
            // FincasForm
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 830, 580 );
            Controls.Add( tabControl );
            Controls.Add( panelTop );
            FormBorderStyle = FormBorderStyle.None;
            Name = "FincasForm";
            Text = "FincasForm";
            panelTop.ResumeLayout( false );
            panelTop.PerformLayout();
            tabControl.ResumeLayout( false );
            tbpLista.ResumeLayout( false );
            tbpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFincas).EndInit();
            tbpDetalle.ResumeLayout( false );
            tbpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
        private PictureBox pictureBox;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtFincaID;
        private Label lblFincaID;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label3;
        private Label label4;
        private TextBox txtProductorID;
        private Label lblProductorID;
        private TextBox txtExtensionTotal;
        private Label label5;
        private TextBox txtDireccion;
        private TextBox txtFechaRegistro;
        private Label lblFechaRegistro;
        private ComboBox cmbProductorNombre;
    }
}