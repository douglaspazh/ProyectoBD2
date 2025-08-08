namespace ProyectoBD2.Views.Forms
{
    partial class ClientesView
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
            tabControl1 = new TabControl();
            tbpLista = new TabPage();
            dgvClientes = new DataGridView();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            lblRecordsPerPage = new Label();
            cmbRecordsPerPage = new ComboBox();
            label6 = new Label();
            lblPaginas = new Label();
            lblTotalRegistros = new Label();
            tbpDetallesCliente = new TabPage();
            label1 = new Label();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            label10 = new Label();
            txtRTN = new TextBox();
            label8 = new Label();
            txtDocumento = new TextBox();
            label7 = new Label();
            txtClienteID = new TextBox();
            lblClienteID = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            tabControl1.SuspendLayout();
            tbpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tbpDetallesCliente.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpLista);
            tabControl1.Controls.Add(tbpDetallesCliente);
            tabControl1.Location = new Point(-1, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1018, 794);
            tabControl1.TabIndex = 2;
            // 
            // tbpLista
            // 
            tbpLista.Controls.Add(dgvClientes);
            tbpLista.Controls.Add(btnSiguiente);
            tbpLista.Controls.Add(btnAnterior);
            tbpLista.Controls.Add(label2);
            tbpLista.Controls.Add(txtBuscar);
            tbpLista.Controls.Add(btnBuscar);
            tbpLista.Controls.Add(btnEditar);
            tbpLista.Controls.Add(btnAgregar);
            tbpLista.Controls.Add(lblRecordsPerPage);
            tbpLista.Controls.Add(cmbRecordsPerPage);
            tbpLista.Controls.Add(label6);
            tbpLista.Controls.Add(lblPaginas);
            tbpLista.Controls.Add(lblTotalRegistros);
            tbpLista.Location = new Point(4, 29);
            tbpLista.Name = "tbpLista";
            tbpLista.Padding = new Padding(3);
            tbpLista.Size = new Size(1010, 761);
            tbpLista.TabIndex = 0;
            tbpLista.Text = "Lista de Clientes";
            tbpLista.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(9, 90);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 25;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(843, 617);
            dgvClientes.TabIndex = 28;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(756, 715);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(109, 40);
            btnSiguiente.TabIndex = 27;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnterior.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(641, 715);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(109, 40);
            btnAnterior.TabIndex = 26;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 14);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 23;
            label2.Text = "Buscar cliente:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(10, 40);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese un nombre o DNI";
            txtBuscar.Size = new Size(533, 29);
            txtBuscar.TabIndex = 24;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(554, 38);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 44);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(871, 164);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(114, 43);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(871, 103);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 43);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblRecordsPerPage
            // 
            lblRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecordsPerPage.AutoSize = true;
            lblRecordsPerPage.Location = new Point(332, 729);
            lblRecordsPerPage.Name = "lblRecordsPerPage";
            lblRecordsPerPage.Size = new Size(189, 20);
            lblRecordsPerPage.TabIndex = 19;
            lblRecordsPerPage.Text = "({}) Productores por página";
            // 
            // cmbRecordsPerPage
            // 
            cmbRecordsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbRecordsPerPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecordsPerPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRecordsPerPage.FormattingEnabled = true;
            cmbRecordsPerPage.Items.AddRange(new object[] { "Auto", "10", "20", "30", "40", "50", "100" });
            cmbRecordsPerPage.Location = new Point(252, 725);
            cmbRecordsPerPage.Margin = new Padding(3, 4, 3, 4);
            cmbRecordsPerPage.Name = "cmbRecordsPerPage";
            cmbRecordsPerPage.Size = new Size(74, 29);
            cmbRecordsPerPage.TabIndex = 18;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(177, 728);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 17;
            label6.Text = "Mostrar";
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(522, 731);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(102, 20);
            lblPaginas.TabIndex = 16;
            lblPaginas.Text = "Página {} de {}";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRegistros.Location = new Point(9, 725);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(162, 23);
            lblTotalRegistros.TabIndex = 15;
            lblTotalRegistros.Text = "Total: {} productores";
            // 
            // tbpDetallesCliente
            // 
            tbpDetallesCliente.Controls.Add(label1);
            tbpDetallesCliente.Controls.Add(txtDireccion);
            tbpDetallesCliente.Controls.Add(txtApellido);
            tbpDetallesCliente.Controls.Add(label10);
            tbpDetallesCliente.Controls.Add(txtRTN);
            tbpDetallesCliente.Controls.Add(label8);
            tbpDetallesCliente.Controls.Add(txtDocumento);
            tbpDetallesCliente.Controls.Add(label7);
            tbpDetallesCliente.Controls.Add(txtClienteID);
            tbpDetallesCliente.Controls.Add(lblClienteID);
            tbpDetallesCliente.Controls.Add(btnCancelar);
            tbpDetallesCliente.Controls.Add(btnGuardar);
            tbpDetallesCliente.Controls.Add(txtEmail);
            tbpDetallesCliente.Controls.Add(label3);
            tbpDetallesCliente.Controls.Add(txtTelefono);
            tbpDetallesCliente.Controls.Add(label5);
            tbpDetallesCliente.Controls.Add(txtNombre);
            tbpDetallesCliente.Controls.Add(lblNombre);
            tbpDetallesCliente.Location = new Point(4, 29);
            tbpDetallesCliente.Name = "tbpDetallesCliente";
            tbpDetallesCliente.Padding = new Padding(3);
            tbpDetallesCliente.Size = new Size(1010, 761);
            tbpDetallesCliente.TabIndex = 1;
            tbpDetallesCliente.Text = "Detalles del Cliente";
            tbpDetallesCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(27, 293);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 53;
            label1.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9.75F);
            txtDireccion.Location = new Point(26, 320);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.MaxLength = 50;
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(496, 131);
            txtDireccion.TabIndex = 52;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(278, 69);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.MaxLength = 25;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 29);
            txtApellido.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(278, 42);
            label10.Name = "label10";
            label10.Size = new Size(76, 23);
            label10.TabIndex = 49;
            label10.Text = "Apellido:";
            // 
            // txtRTN
            // 
            txtRTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRTN.Location = new Point(278, 154);
            txtRTN.Margin = new Padding(3, 4, 3, 4);
            txtRTN.MaxLength = 20;
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(175, 29);
            txtRTN.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(278, 128);
            label8.Name = "label8";
            label8.Size = new Size(45, 23);
            label8.TabIndex = 47;
            label8.Text = "RTN:";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(26, 154);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.MaxLength = 13;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(175, 29);
            txtDocumento.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 128);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 45;
            label7.Text = "Documento:";
            // 
            // txtClienteID
            // 
            txtClienteID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClienteID.Location = new Point(549, 66);
            txtClienteID.Margin = new Padding(3, 4, 3, 4);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.ReadOnly = true;
            txtClienteID.Size = new Size(114, 29);
            txtClienteID.TabIndex = 44;
            txtClienteID.TabStop = false;
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClienteID.Location = new Point(549, 40);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(84, 23);
            lblClienteID.TabIndex = 43;
            lblClienteID.Text = "ClienteID:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Location = new Point(451, 506);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 40);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F);
            btnGuardar.Location = new Point(278, 506);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F);
            txtEmail.Location = new Point(27, 249);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 29);
            txtEmail.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(26, 213);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 39;
            label3.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9.75F);
            txtTelefono.Location = new Point(549, 154);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 8;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(216, 29);
            txtTelefono.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(549, 127);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 37;
            label5.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(26, 66);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 29);
            txtNombre.TabIndex = 36;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(26, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombre:";
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 859);
            Controls.Add(tabControl1);
            Name = "ClientesView";
            Text = "ClientesView";
            tabControl1.ResumeLayout(false);
            tbpLista.ResumeLayout(false);
            tbpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tbpDetallesCliente.ResumeLayout(false);
            tbpDetallesCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpLista;
        private TabPage tbpDetallesCliente;
        private Label lblTotalRegistros;
        private Label label6;
        private ComboBox cmbRecordsPerPage;
        private Label lblPaginas;
        private Label lblRecordsPerPage;
        private Button btnEliminar2;
        private TextBox txtApellido;
        private Label label10;
        private TextBox txtRTN;
        private Label label8;
        private TextBox txtDocumento;
        private Label label7;
        private TextBox txtClienteID;
        private Label lblClienteID;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnSiguiente;
        private Button btnAnterior;
        private DataGridView dgvClientes;
    }
}