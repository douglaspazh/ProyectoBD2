namespace ProyectoBD2.Views.Forms
{
    partial class CosechasView
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
            label1 = new Label();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelTop = new Panel();
            tabDetalle = new TabPage();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            TipoCultivo = new Label();
            tabLista = new TabPage();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvCosecha = new DataGridView();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            tabControl1 = new TabControl();
            panelTop.SuspendLayout();
            tabDetalle.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCosecha).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 20);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 4;
            label1.Text = "COSECHA";
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
            btnCerrar.Location = new Point(873, 7);
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
            // panelTop
            // 
            panelTop.Controls.Add(iconButton1);
            panelTop.Controls.Add(btnCerrar);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(949, 67);
            panelTop.TabIndex = 8;
            // 
            // tabDetalle
            // 
            tabDetalle.Controls.Add(comboBox2);
            tabDetalle.Controls.Add(comboBox1);
            tabDetalle.Controls.Add(textBox4);
            tabDetalle.Controls.Add(textBox2);
            tabDetalle.Controls.Add(label7);
            tabDetalle.Controls.Add(label6);
            tabDetalle.Controls.Add(label5);
            tabDetalle.Controls.Add(dateTimePicker2);
            tabDetalle.Controls.Add(label4);
            tabDetalle.Controls.Add(dateTimePicker1);
            tabDetalle.Controls.Add(label3);
            tabDetalle.Controls.Add(btnCancelar);
            tabDetalle.Controls.Add(btnGuardar);
            tabDetalle.Controls.Add(TipoCultivo);
            tabDetalle.Location = new Point(4, 29);
            tabDetalle.Name = "tabDetalle";
            tabDetalle.Padding = new Padding(3);
            tabDetalle.Size = new Size(941, 705);
            tabDetalle.TabIndex = 1;
            tabDetalle.Text = "Detalles Cosecha";
            tabDetalle.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(274, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 28);
            comboBox2.TabIndex = 72;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(532, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 71;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F);
            textBox4.Location = new Point(274, 239);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 29);
            textBox4.TabIndex = 70;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F);
            textBox2.Location = new Point(275, 155);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 29);
            textBox2.TabIndex = 66;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(275, 203);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 69;
            label7.Text = "Precios:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(532, 46);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 67;
            label6.Text = "Lote:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(275, 128);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 65;
            label5.Text = "Cantidad:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(532, 241);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(151, 27);
            dateTimePicker2.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(532, 203);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 63;
            label4.Text = "Fecha Final:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(534, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 27);
            dateTimePicker1.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(534, 128);
            label3.Name = "label3";
            label3.Size = new Size(149, 23);
            label3.TabIndex = 61;
            label3.Text = "Fecha de Siembra:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Location = new Point(502, 369);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 40);
            btnCancelar.TabIndex = 59;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F);
            btnGuardar.Location = new Point(370, 369);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 58;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // TipoCultivo
            // 
            TipoCultivo.AutoSize = true;
            TipoCultivo.Font = new Font("Segoe UI", 9.75F);
            TipoCultivo.Location = new Point(274, 46);
            TipoCultivo.Name = "TipoCultivo";
            TipoCultivo.Size = new Size(84, 23);
            TipoCultivo.TabIndex = 57;
            TipoCultivo.Text = "CultivoID:";
            // 
            // tabLista
            // 
            tabLista.Controls.Add(btnEliminar);
            tabLista.Controls.Add(btnEditar);
            tabLista.Controls.Add(btnAgregar);
            tabLista.Controls.Add(dgvCosecha);
            tabLista.Controls.Add(label2);
            tabLista.Controls.Add(txtBuscar);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Location = new Point(4, 29);
            tabLista.Margin = new Padding(3, 4, 3, 4);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3, 4, 3, 4);
            tabLista.Size = new Size(941, 705);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista de Cosechas";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(801, 186);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 40);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(801, 138);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 40);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(801, 90);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 40);
            btnAgregar.TabIndex = 20;
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
            dgvCosecha.Location = new Point(9, 90);
            dgvCosecha.Margin = new Padding(3, 4, 3, 4);
            dgvCosecha.MultiSelect = false;
            dgvCosecha.Name = "dgvCosecha";
            dgvCosecha.ReadOnly = true;
            dgvCosecha.RowHeadersVisible = false;
            dgvCosecha.RowHeadersWidth = 25;
            dgvCosecha.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCosecha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCosecha.Size = new Size(783, 609);
            dgvCosecha.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 14);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 16;
            label2.Text = "Buscar Cosecha:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(10, 40);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(410, 29);
            txtBuscar.TabIndex = 17;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.AutoSize = true;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(426, 38);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 44);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabLista);
            tabControl1.Controls.Add(tabDetalle);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(147, 25);
            tabControl1.Location = new Point(0, 67);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(949, 738);
            tabControl1.TabIndex = 9;
            // 
            // CosechasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 805);
            Controls.Add(tabControl1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CosechasView";
            Text = "CosechasView";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            tabDetalle.ResumeLayout(false);
            tabDetalle.PerformLayout();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCosecha).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelTop;
        private TabPage tabDetalle;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label TipoCultivo;
        private TabPage tabLista;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dgvCosecha;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private TabControl tabControl1;
    }
}