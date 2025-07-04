using ProyectoBD2.Models;
using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Views.Interfaces;

namespace ProyectoBD2.Presenters
{
    public class ProductorPresenter
    {
        // Fields
        private readonly IProductorView _view;
        private readonly IProductorRepository _repository;
        private readonly BindingSource _bindingSource;
        private IEnumerable<Productor> _productoresList;

        private const string DefaultDateFormat = "dd/MM/yyyy";
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
            
            LoadProductoresByPage( _actualPage );
        }

        // Methods
        private void LoadAllProductores()
        {
            _productoresList = _repository.GetAllProductores();
            _bindingSource.DataSource = _productoresList;
        }

        private void LoadProductoresByPage( int pageNumber )
        {
            _actualPage = pageNumber;
            _productoresList = _repository.GetAllProductores()
                                          .Skip((pageNumber - 1) * _pageSize)
                                          .Take(_pageSize)
                                          .ToList();
            _bindingSource.DataSource = _productoresList;
            UpdatePageInfo();
        }

        private void OnSearchEvent( object? sender, EventArgs e )
        {
            bool emptySearch = string.IsNullOrWhiteSpace(_view.SearchTerm);
            if (!emptySearch)
            {
                _productoresList = _repository.GetByValue(_view.SearchTerm);
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
            var selectedProductor = _bindingSource.Current as Productor;
            if ( selectedProductor != null )
            {
                _view.IsEditing = true;
                _view.ProductorID = selectedProductor!.ProductorID;
                _view.Nombre = selectedProductor.Nombre;
                _view.Telefono = selectedProductor.Telefono;
                _view.Email = selectedProductor.Email;
                _view.Estado = selectedProductor.Estado;
                _view.FechaRegistro = selectedProductor.FechaRegistro.ToString( DefaultDateFormat );
            }
        }

        private void DeleteSelectedProductor( object? sender, EventArgs e )
        {
            try
            {
                var selectedProductor = _bindingSource.Current as Productor;
                if ( selectedProductor != null )
                {
                    _repository.DeleteProductor( selectedProductor!.ProductorID );
                    _view.IsSuccessful = true;
                    _view.Message = "Productor eliminado exitosamente.";
                    LoadAllProductores();
                }
                else
                {
                    _view.IsSuccessful = false;
                    _view.Message = "No se ha seleccionado ningún productor.";
                }
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = $"Error: {ex.Message}";
            }
        }

        private void SaveProductor( object? sender, EventArgs e )
        {
            try
            {
                Productor productor = new()
                {
                    ProductorID = _view.ProductorID,
                    Nombre = _view.Nombre,
                    Telefono = _view.Telefono,
                    Email = _view.Email,
                    Estado = _view.Estado,
                    FechaRegistro = DateOnly.ParseExact( _view.FechaRegistro, DefaultDateFormat )
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
                LoadAllProductores();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = $"Error saving productor: {ex.Source}";
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
            _view.Telefono = string.Empty;
            _view.Email = string.Empty;
            _view.Estado = string.Empty;
            _view.FechaRegistro = DateOnly.FromDateTime(DateTime.Now).ToString(DefaultDateFormat);
        }

        private void UpdatePageInfo()
        {
            _totalRecords = _repository.GetAllProductores().Count();
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            _view.DisplayPageRange(_actualPage, _totalPages, _totalRecords);
        }
    }
}
