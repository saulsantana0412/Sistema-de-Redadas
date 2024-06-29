namespace Proyecto_Final.Models
{
    public class Redada
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Tipo_Vehiculo { get; set; } = "";
        public string Responsable { get; set; } = "";
        public DateOnly FechaRedada { get; set; }
    }
}
