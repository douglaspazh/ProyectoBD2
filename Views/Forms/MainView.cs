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
    public partial class MainView : Form
    {
        public MainView()
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

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add( childForm );
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnProductores_Click( object sender, EventArgs e )
        {
            OpenChildForm( new ProductoresView() );
        }

        private void btnFincas_Click( object sender, EventArgs e )
        {
            OpenChildForm( new FincasView() );
        }
    }
}
