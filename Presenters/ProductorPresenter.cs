using ProyectoBD2.Models;
using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Views.Interfaces;
using System.Data;

namespace ProyectoBD2.Presenters
{
    public class ProductorPresenter
    {
        // Fields
        private readonly IProductorView _view;
        private readonly IProductorRepository _repository;
        private readonly BindingSource _bindingSource;
        private DataTable _productoresList;

        private int _actualPage = 1;
        private int _pageSize = 25;
        private int _totalPages = 0;
        private int _totalRecords = 0;

        // Constructor
        public ProductorPresenter( IProductorView view, IProductorRepository repository )
        {
            this._bindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;

            this._view.SearchEvent += OnSearchEvent;
            this._view.AddNewEvent += AddNewProductor;
            this._view.EditEvent += LoadSelectedProductorToEdit;
            this._view.DeleteEvent += DeleteSelectedProductor;
            this._view.SaveEvent += SaveProductor;
            this._view.CancelEvent += CancelAction;
            this._view.NextPageEvent += ( s, e ) => LoadProductoresByPage( _actualPage + 1 );
            this._view.PrevPageEvent += ( s, e ) => LoadProductoresByPage( _actualPage - 1 );

            this._view.SetListBindingSource( _bindingSource );
            this._view.DisplayPageRange( _actualPage, _totalPages, _totalRecords );
            this._view.CargarEstados( _repository.GetAllEstados() );

            LoadProductoresByPage( _actualPage );
        }

        // Methods
        private void LoadProductoresByPage( int pageNumber )
        {
            _actualPage = pageNumber;
            _productoresList = _repository.GetAllProductores();
            _bindingSource.DataSource = _productoresList;
            UpdatePageInfo();
        }

        // Event Handlers
        private void OnSearchEvent( object? sender, EventArgs e )
        {
            bool emptySearch = string.IsNullOrWhiteSpace( _view.SearchTerm );
            if (!emptySearch)
            {
                _productoresList = _repository.GetByValue( _view.SearchTerm );
            }
            else
            {
                _productoresList = _repository.GetAllProductores();
            }
            _bindingSource.DataSource = _productoresList;
        }

        private void AddNewProductor( object? sender, EventArgs e )
        {
            _view.IsEditing = false;
        }

        private void LoadSelectedProductorToEdit( object? sender, EventArgs e )
        {
            var selectedProductor = _bindingSource.Current as DataRowView;
            
            if ( selectedProductor != null )
            {
                _view.IsEditing = true;
                _view.ProductorID = Convert.ToInt32( selectedProductor["ProductorID"] );

                var productorData = _repository.GetProductorById( _view.ProductorID );

                if ( productorData.Rows.Count > 0 ) // Ensure there is at least one row in the DataTable
                {
                    var row = productorData.Rows[0]; // Access the first row of the DataTable

                    _view.Nombre = row["Nombre"].ToString() ?? string.Empty;
                    _view.Apellido = row["Apellido"].ToString() ?? string.Empty;
                    _view.Telefono = row["Telefono"].ToString() ?? string.Empty;
                    _view.Correo = row["Correo"].ToString() ?? string.Empty;
                    _view.Documento = row["Documento"].ToString() ?? string.Empty;
                    _view.RTN = row["RTN"].ToString() ?? string.Empty;
                    _view.Direccion = row["Direccion"].ToString() ?? string.Empty;
                    _view.EstadoID = Convert.ToInt32( row["EstadoID"] );
                }
            }
        }

        private void DeleteSelectedProductor( object? sender, EventArgs e )
        {
            try
            {
                var selectedProductor = _bindingSource.Current as DataRowView;

                if ( selectedProductor != null )
                {
                    int productorId = Convert.ToInt32( selectedProductor["ProductorID"] );
                    _repository.DeleteProductor( productorId );
                    _view.IsSuccessful = true;
                    _view.Message = "Productor eliminado exitosamente.";

                    LoadProductoresByPage( _actualPage );
                }
                else
                {
                    _view.IsSuccessful = false;
                    _view.Message = "No se ha seleccionado ningún productor.";
                }
            }
            catch ( Exception ex )
            {
                _view.IsSuccessful = false;
                _view.Message = $"Error: {ex.Message}";
            }
        }

        private void SaveProductor( object? sender, EventArgs e )
        {
            try
            {
                Dictionary<string, dynamic> productor = new()
                {
                    { "ProductorID", _view.ProductorID },
                    { "Nombre", _view.Nombre },
                    { "Apellido", _view.Apellido },
                    { "Direccion", _view.Direccion },
                    { "Telefono", _view.Telefono },
                    { "Correo", _view.Correo },
                    { "Documento", _view.Documento }, 
                    { "RTN", _view.RTN },
                    { "EstadoID", _view.EstadoID }
                };

                if ( _view.IsEditing )
                {
                    _repository.UpdateProductor( productor );
                    _view.Message = "Productor actualizado exitosamente.";
                }
                else
                {
                    _repository.AddProductor( productor );
                    _view.Message = "Productor agregado exitosamente.";
                }

                _view.IsSuccessful = true;
                CleanViewFields();
                LoadProductoresByPage( _actualPage );
            }
            catch ( Exception ex )
            {
                _view.IsSuccessful = false;
                _view.Message = $"Error saving productor: {ex.Message}";
            }
        }

        private void CancelAction( object? sender, EventArgs e )
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            _view.ProductorID = 0;
            _view.Nombre = string.Empty;
            _view.Apellido = string.Empty;
            _view.Telefono = string.Empty;
            _view.Correo = string.Empty;
            _view.Documento = string.Empty;
            _view.RTN = string.Empty;
            _view.Direccion = string.Empty;
            _view.EstadoID = 0;
        }

        private void UpdatePageInfo()
        {
            _totalRecords = _repository.GetAllProductores().Rows.Count;
            _totalPages = (int)Math.Ceiling( (double)_totalRecords / _pageSize );
            _view.DisplayPageRange( _actualPage, _totalPages, _totalRecords );
        }
    }
}
