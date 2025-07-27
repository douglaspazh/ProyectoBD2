namespace ProyectoBD2.Views.Interfaces
{
    public interface IFincaView
    {
        // Properties
        int FincaID { get; set; }
        int ProductorID { get; set; }
        string Nombre { get; set; }
        string ProductorNombre { get; set; }
        string Direccion { get; set; }
        decimal ExtensionTotal { get; set; }
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

        // Methods
        void SetListBindingSource(BindingSource fincas);
        void Show();
    }
}
