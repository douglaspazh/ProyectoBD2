using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Views.Interfaces;
using ProyectoBD2.Models;

namespace ProyectoBD2.Presenters
{
    public class FincaPresenter
    {
        // Fields
        private IFincaView _view;
        private IFincaRepository _repository;
        private BindingSource _bindingSource;
        private IEnumerable<Finca> _fincasList;

        // Constructor
        public FincaPresenter( IFincaView view, IFincaRepository repository )
        {
            this._bindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;

            this._view.SearchEvent += OnSearchEvent;
            this._view.AddNewEvent += AddNewFinca;
            this._view.EditEvent += LoadSelectedFincaToEdit;
            this._view.DeleteEvent += DeleteSelectedFinca;
            this._view.SaveEvent += SaveFinca;
            this._view.CancelEvent += CancelAction;
            this._view.SetListBindingSource( _bindingSource );
            LoadAllFincas();
        }

        // Methods
        private void LoadAllFincas()
        {
            _fincasList = _repository.GetAllFincas();
            _bindingSource.DataSource = _fincasList;
        }

        private void OnSearchEvent( object sender, EventArgs e )
        {
            bool emptySearch = string.IsNullOrWhiteSpace( _view.SearchTerm );
            if ( !emptySearch )
            {
                _fincasList = _repository.GetByValue( _view.SearchTerm );
            }
            else
            {
                _fincasList = _repository.GetAllFincas();
            }
            _bindingSource.DataSource = _fincasList;
        }

        private void AddNewFinca( object? sender, EventArgs e )
        {
            _view.IsEditing = false;
        }

        private void LoadSelectedFincaToEdit( object? sender, EventArgs e )
        {
            var selectedFinca = _bindingSource.Current as Finca;
            if ( selectedFinca != null )
            {
                _view.FincaID = selectedFinca.FincaID;
                _view.ProductorID = selectedFinca.ProductorID;
                _view.Nombre = selectedFinca.Nombre;
                _view.ExtensionTotal = selectedFinca.ExtensionTotal;
                _view.IsEditing = true;
            }
        }

        private void DeleteSelectedFinca( object? sender, EventArgs e )
        {
            try
            {
                var selectedFinca = _bindingSource.Current as Finca;
                if ( selectedFinca != null )
                {
                    _repository.DeleteFinca( selectedFinca.FincaID );
                    _view.IsSuccessful = true;
                    _view.Message = "Finca eliminada exitosamente.";
                    LoadAllFincas();
                }
                else
                {
                    _view.IsSuccessful = false;
                    _view.Message = "No se ha selenccionado ninguna finca.";
                }
            }
            catch ( Exception ex )
            {
                _view.IsSuccessful = false;
                _view.Message = $"Error deleting finca: {ex.Message}";
            }
        }

        private void SaveFinca( object? sender, EventArgs e )
        {
            try
            {
                Finca finca = new()
                {
                    FincaID = _view.FincaID,
                    ProductorID = _view.ProductorID,
                    Nombre = _view.Nombre,
                    Direccion = _view.Ubicacion,
                    ExtensionTotal = _view.ExtensionTotal,
                };

                if ( _view.IsEditing )
                {
                    _repository.UpdateFinca( finca );
                    _view.Message = "Finca actualizada exitosamente.";
                }
                else
                {
                    _repository.AddFinca( finca );
                    _view.Message = "Finca agregada exitosamente.";
                }

                _view.IsSuccessful = true;
                LoadAllFincas();
                ClearViewFields();
            }
            catch ( Exception ex )
            {
                _view.IsSuccessful = false;
                _view.Message = $"Error saving finca: {ex.Message}";
            }
        }

        private void CancelAction( object? sender, EventArgs e )
        {
            ClearViewFields();
        }

        private void ClearViewFields()
        {
            _view.FincaID = 0;
            _view.ProductorID = 0;
            _view.Nombre = string.Empty;
            _view.Ubicacion = string.Empty;
            _view.ExtensionTotal = 0;
        }
    }
}
