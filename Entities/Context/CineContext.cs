using Microsoft.EntityFrameworkCore;

namespace CINE.Api.Entities.Context
{
    public class CineContext : DbContext
    {
        public CineContext(DbContextOptions<CineContext> options) : base(options) { }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<SalaCine> SalasCine { get; set; }
        public DbSet<PeliculaSalaCine> PeliculasSalaCine { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>()
                .ToTable("pelicula")
                .Property(p => p.IdPelicula)
                .HasColumnName("id_pelicula");

            modelBuilder.Entity<SalaCine>()
                .ToTable("sala_cine")
                .Property(s => s.IdSala)
                .HasColumnName("id_sala");

            modelBuilder.Entity<PeliculaSalaCine>()
                .ToTable("pelicula_sala_cine")
                .Property(ps => ps.IdPeliculaSala)
                .HasColumnName("id_pelicula_sala");

            modelBuilder.Entity<PeliculaSalaCine>()
                .Property(ps => ps.IdPelicula)
                .HasColumnName("id_pelicula");

            modelBuilder.Entity<PeliculaSalaCine>()
                .Property(ps => ps.IdSalaCine)
                .HasColumnName("id_sala");

            modelBuilder.Entity<PeliculaSalaCine>()
                .Property(ps => ps.FechaPublicacion)
                .HasColumnName("fecha_publicacion");

            modelBuilder.Entity<PeliculaSalaCine>()
                .Property(ps => ps.FechaFin)
                .HasColumnName("fecha_fin");

            modelBuilder.Entity<PeliculaSalaCine>()
                .HasKey(ps => ps.IdPeliculaSala);

            modelBuilder.Entity<PeliculaSalaCine>()
                .HasOne(ps => ps.Pelicula)
                .WithMany()
                .HasForeignKey(ps => ps.IdPelicula);

            modelBuilder.Entity<PeliculaSalaCine>()
                .HasOne(ps => ps.SalaCine)
                .WithMany()
                .HasForeignKey(ps => ps.IdSalaCine);
        }

    }
}
