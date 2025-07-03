using ProyectoBD2.Models;
using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Views.Interfaces;

namespace ProyectoBD2.Presenters
{
    public class ProductorPresenter
    {
        // Fields
        private IProductorView _view;
        private IProductorRepository _repository;
        private BindingSource _bindingSource;
        private IEnumerable<Productor> _productoresList;

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

            this._view.SetListBindingSource(_bindingSource);
            LoadAllProductores();
        }

        // Methods
        private void LoadAllProductores()
        {
            _productoresList = _repository.GetAllProductores();
            _bindingSource.DataSource = _productoresList;
        }

        private void OnSearchEvent( object sender, EventArgs e )
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
            var productor = _bindingSource.Current as Productor;
            _view.IsEditing = true;
            _view.ProductorID = productor!.ProductorID;
            _view.Nombre = productor.Nombre;
            _view.Telefono = productor.Telefono;
            _view.Email = productor.Email;
            _view.Estado = productor.Estado;
            _view.FechaRegistro = productor.FechaRegistro.ToString("dd/MM/yyyy");
        }

        private void DeleteSelectedProductor( object? sender, EventArgs e )
        {
            try
            {
                var productor = _bindingSource.Current as Productor;
                _repository.DeleteProductor(productor!.ProductorID);
                _view.IsSuccessful = true;
                _view.Message = "Productor eliminado exitosamente.";
                LoadAllProductores();
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
                    FechaRegistro = DateOnly.ParseExact( _view.FechaRegistro, "dd/MM/yyyy" )
                };

                if ( _view.IsEditing )
                    _repository.UpdateProductor( productor );
                else
                    _repository.AddProductor( productor );

                _view.IsSuccessful = true;
                LoadAllProductores();
                CleanViewFields();
                _view.Message = "Operación exitosa.";
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = $"Error: {ex.Message}";
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
            _view.FechaRegistro = DateOnly.FromDateTime(DateTime.Now).ToString("dd/MM/yyyy");
        }

    }
}
