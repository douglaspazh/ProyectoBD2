namespace ProyectoBD2.Views.Forms
{
    partial class MainForm
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
            panelMenu = new Panel();
            btnFincas = new FontAwesome.Sharp.IconButton();
            btnProductores = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panelContainer = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add( btnFincas );
            panelMenu.Controls.Add( btnProductores );
            panelMenu.Controls.Add( panelLogo );
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point( 0, 0 );
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size( 170, 605 );
            panelMenu.TabIndex = 2;
            // 
            // btnFincas
            // 
            btnFincas.FlatStyle = FlatStyle.Flat;
            btnFincas.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnFincas.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            btnFincas.IconColor = Color.Black;
            btnFincas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFincas.IconSize = 32;
            btnFincas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFincas.Location = new Point( 0, 127 );
            btnFincas.Name = "btnFincas";
            btnFincas.Padding = new Padding( 5, 0, 0, 0 );
            btnFincas.Size = new Size( 170, 40 );
            btnFincas.TabIndex = 3;
            btnFincas.Text = "Fincas";
            btnFincas.UseVisualStyleBackColor = true;
            btnFincas.Click += btnFincas_Click;
            // 
            // btnProductores
            // 
            btnProductores.FlatStyle = FlatStyle.Flat;
            btnProductores.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0 );
            btnProductores.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnProductores.IconColor = Color.Black;
            btnProductores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProductores.IconSize = 32;
            btnProductores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductores.Location = new Point( 0, 81 );
            btnProductores.Name = "btnProductores";
            btnProductores.Padding = new Padding( 5, 0, 0, 0 );
            btnProductores.Size = new Size( 170, 40 );
            btnProductores.TabIndex = 2;
            btnProductores.Text = "Productores";
            btnProductores.UseVisualStyleBackColor = true;
            btnProductores.Click += btnProductores_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point( 0, 0 );
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size( 170, 75 );
            panelLogo.TabIndex = 1;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point( 170, 0 );
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size( 811, 605 );
            panelContainer.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 981, 605 );
            Controls.Add( panelContainer );
            Controls.Add( panelMenu );
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        private Panel panelMenu;
        private Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnProductores;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnFincas;
    }
}