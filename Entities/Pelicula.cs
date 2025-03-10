using System.ComponentModel.DataAnnotations;

namespace CINE.Api.Entities
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }

        public string Nombre { get; set; } = string.Empty;
        public int Duracion { get; set; }
    }
}
