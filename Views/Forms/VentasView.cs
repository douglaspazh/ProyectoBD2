using ProyectoBD2.Data;
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
    public partial class VentasView : Form
    {
        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;
        private bool isEditing;
        private readonly Utils utils = new();

        public VentasView()
        {
            InitializeComponent();
            SetListBindingSource("spObtenerVentas");
        }

        public void SetListBindingSource(string spName = "spObtenerVentas", Dictionary<string, dynamic>? parameters = null)
        {
            parameters ??= new()
                {
                    { "@PageNumber", _actualPage },
                    { "@PageSize", _pageSize }
                };
            dgvDatos.DataSource = utils.ExecuteSPDataTable(spName, parameters);

            _totalRecords = dgvDatos.Rows.Count;
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            DisplayPageInfo();

        }

        public void DisplayPageInfo()
        {
            lblTotalRegistros.Text = $"Total: {_totalRecords} productores";
            lblPaginas.Text = $"Página {_actualPage} de {_totalPages}";
            lblRecordsPerPage.Text = $"Mostrando {_pageSize} registros por página";
            btnSiguiente.Enabled = _actualPage < _totalPages;
            btnAnterior.Enabled = _actualPage > 1;
        }

    }
}
