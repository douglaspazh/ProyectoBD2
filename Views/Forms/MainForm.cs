using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD2.Views.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm( Form childForm )
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add( childForm );
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnProductores_Click( object sender, EventArgs e )
        {
            OpenChildForm( new ProductoresForm() );
        }

        private void btnFincas_Click( object sender, EventArgs e )
        {
            //OpenChildForm( new FincasForm() );
            throw new NotImplementedException( "FincasForm is not implemented yet." );
        }
    }
}
