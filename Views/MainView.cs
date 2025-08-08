using ProyectoBD2.Views.Forms_Transacciones;
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

        private void btnCosechas_Click( object sender, EventArgs e )
        {
            OpenChildForm( new CosechasView() );
        }

        private void btnCultivos_Click( object sender, EventArgs e )
        {
            OpenChildForm( new CultivosView() );
        }

        private void btnClientes_Click( object sender, EventArgs e )
        {
            OpenChildForm( new ClientesView() );
        }

        private void btnVentas_Click( object sender, EventArgs e )
        {
            OpenChildForm( new VentasView() );
        }

        private void btnProveedores_Click( object sender, EventArgs e )
        {
            OpenChildForm( new ProveedoresView() );
        }

        private void btnCompras_Click( object sender, EventArgs e )
        {
            OpenChildForm( new ComprasView() );
        }

        private void btnFacturas_Click( object sender, EventArgs e )
        {
            OpenChildForm( new FacturasView() );
        }

        private void btnRecibos_Click( object sender, EventArgs e )
        {
            OpenChildForm( new RecibosView() );
        }

        private void btnEntregas_Click( object sender, EventArgs e )
        {

        }

        private void btnSalidas_Click( object sender, EventArgs e )
        {

        }

        private void btnProductos_Click( object sender, EventArgs e )
        {
            OpenChildForm( new ProductosView() );
        }

        private void btnBodegas_Click( object sender, EventArgs e )
        {
            
        }
    }
}
