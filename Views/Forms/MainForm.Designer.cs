namespace ProyectoBD2.UI.Forms
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
            panelLogo = new Panel();
            btnProductores = new Button();
            panelContainer = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add( panelLogo );
            panelMenu.Controls.Add( btnProductores );
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point( 0, 0 );
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size( 170, 605 );
            panelMenu.TabIndex = 2;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point( 0, 0 );
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size( 170, 75 );
            panelLogo.TabIndex = 1;
            // 
            // btnProductores
            // 
            btnProductores.FlatStyle = FlatStyle.Flat;
            btnProductores.Location = new Point( 0, 81 );
            btnProductores.Name = "btnProductores";
            btnProductores.Size = new Size( 170, 30 );
            btnProductores.TabIndex = 0;
            btnProductores.Text = "Productores";
            btnProductores.UseVisualStyleBackColor = true;
            btnProductores.Click += btnProductores_Click;
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
        private Button btnProductores;
        private Panel panelLogo;
    }
}