namespace CINE.Api.Entities
{
    public class PeliculaSalaCine
    {
        public int IdPeliculaSala { get; set; }
        public int IdPelicula { get; set; }
        public int IdSalaCine { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaFin { get; set; }

        public virtual Pelicula? Pelicula { get; set; }
        public virtual SalaCine? SalaCine { get; set; }
    }
}
