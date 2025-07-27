using ProyectoBD2.Models;

namespace ProyectoBD2.Views.Interfaces
{
    public interface IProductorView
    {
        // Properties
        int ProductorID { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        string Correo { get; set; }
        int EstadoID { get; set; }
        string FechaRegistro { get; set; }

        string SearchTerm { get; set; }
        bool IsEditing { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler NextPageEvent;
        event EventHandler PrevPageEvent;

        // Methods
        void SetListBindingSource( BindingSource productores );
        void DisplayPageRange( int currentPage, int totalPages, int totalRecords );
        void CargarEstados(IEnumerable<Estado> estados);
    }
}
