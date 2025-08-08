namespace ProyectoBD2.Views.Forms
{
    partial class CultivosView
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
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvCosecha = new DataGridView();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            tabPage2 = new TabPage();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            pictureBox = new PictureBox();
            ProductoID = new Label();
            CBProductoID = new ComboBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCosecha).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 71);
            panel1.TabIndex = 0;
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
            iconButton1.Location = new Point(10, 9);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(46, 53);
            iconButton1.TabIndex = 12;
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
            btnCerrar.Location = new Point(850, 11);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 48);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 10;
            label1.Text = "CULTIVO";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(917, 755);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(dgvCosecha);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(909, 722);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista Cultivos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(767, 215);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 40);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(767, 153);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 40);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(767, 94);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 40);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvCosecha
            // 
            dgvCosecha.AllowUserToAddRows = false;
            dgvCosecha.AllowUserToDeleteRows = false;
            dgvCosecha.AllowUserToResizeColumns = false;
            dgvCosecha.AllowUserToResizeRows = false;
            dgvCosecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCosecha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCosecha.BorderStyle = BorderStyle.None;
            dgvCosecha.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCosecha.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCosecha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCosecha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCosecha.EnableHeadersVisualStyles = false;
            dgvCosecha.Location = new Point(5, 94);
            dgvCosecha.Margin = new Padding(3, 4, 3, 4);
            dgvCosecha.MultiSelect = false;
            dgvCosecha.Name = "dgvCosecha";
            dgvCosecha.ReadOnly = true;
            dgvCosecha.RowHeadersVisible = false;
            dgvCosecha.RowHeadersWidth = 25;
            dgvCosecha.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCosecha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCosecha.Size = new Size(738, 602);
            dgvCosecha.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 20;
            label2.Text = "Buscar Cosecha:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(6, 44);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(414, 29);
            txtBuscar.TabIndex = 21;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(426, 29);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 44);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(txtNombre);
            tabPage2.Controls.Add(lblNombre);
            tabPage2.Controls.Add(pictureBox);
            tabPage2.Controls.Add(ProductoID);
            tabPage2.Controls.Add(CBProductoID);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(909, 722);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalle Cultivos";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Location = new Point(389, 400);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 40);
            btnCancelar.TabIndex = 81;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F);
            btnGuardar.Location = new Point(268, 400);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 80;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(258, 245);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 79;
            label3.Text = "Observaciones:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 281);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 72);
            textBox1.TabIndex = 78;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(258, 85);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(351, 29);
            txtNombre.TabIndex = 77;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(258, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 76;
            lblNombre.Text = "Nombre:";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(49, 45);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(143, 166);
            pictureBox.TabIndex = 75;
            pictureBox.TabStop = false;
            // 
            // ProductoID
            // 
            ProductoID.AutoSize = true;
            ProductoID.Font = new Font("Segoe UI", 9.75F);
            ProductoID.Location = new Point(258, 137);
            ProductoID.Name = "ProductoID";
            ProductoID.Size = new Size(101, 23);
            ProductoID.TabIndex = 74;
            ProductoID.Text = "ProductoID:";
            ProductoID.Click += ProductoID_Click;
            // 
            // CBProductoID
            // 
            CBProductoID.FormattingEnabled = true;
            CBProductoID.Location = new Point(258, 172);
            CBProductoID.Name = "CBProductoID";
            CBProductoID.Size = new Size(190, 28);
            CBProductoID.TabIndex = 73;
            CBProductoID.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // CultivosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 826);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CultivosView";
            Text = "CultivosView";
            Load += CultivosView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCosecha).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvCosecha;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private ComboBox CBProductoID;
        private Label ProductoID;
        private PictureBox pictureBox;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}