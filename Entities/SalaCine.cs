using System.ComponentModel.DataAnnotations;

namespace CINE.Api.Entities
{
    public class SalaCine
    {
        [Key] 
        public int IdSala { get; set; }

        public string? Nombre { get; set; } = string.Empty;
        public bool Estado { get; set; } = true;
        public string EstadoTexto => Estado ? "Activo" : "Inactivo";
    }
}
