using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Persona
    {
		public int Id { get; set; }
		public string Nombre { get; set; } = "";
		public string Apellido { get; set; } = "";
		public string Nacionalidad { get; set; } = "";
		public string Identificacion { get; set; }="";
		public string Color { get; set; } = "";
		public string Genero { get; set; } = "";
		public DateOnly Fecha_Nacimiento { get; set; }
		public string Codigo_Vital { get; set; } = "";
		public float Latitud { get; set; }
		public float Longitud { get; set; }
		public int Dinero { get; set; }
		public int Id_Redada { get; set;}

    }
}
