using Microsoft.EntityFrameworkCore;

namespace SpotifyLiteUsuario.Repository.Context
{
    public class SpotifyUsuarioContext : DbContext
    {

        public SpotifyUsuarioContext(DbContextOptions<SpotifyUsuarioContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SpotifyUsuarioContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
