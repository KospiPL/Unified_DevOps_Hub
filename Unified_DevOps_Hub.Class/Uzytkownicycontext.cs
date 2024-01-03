using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Unified_DevOps_Hub.Class
{
    public class UzytkownicyContext : DbContext
    {
        public DbSet<Użytkownicy> Użytkownicy { get; set; }

        private readonly IConfiguration _configuration;

        public UzytkownicyContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DevOpsHubDatabase");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definicja klucza głównego
            modelBuilder.Entity<Użytkownicy>()
                .HasKey(u => u.Id_Użytkownika);

            modelBuilder.Entity<Użytkownicy>()
                .Property(u => u.Imie)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Użytkownicy>()
                .Property(u => u.Nazwisko)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Użytkownicy>()
                .Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Użytkownicy>()
                .Property(u => u.Haslo)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Użytkownicy>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Użytkownicy>()
                .Property(u => u.Miejscowosc)
                .HasMaxLength(100);

            modelBuilder.Entity<Użytkownicy>()
                .Property(u => u.Dział)
                .HasMaxLength(100);

        }
    }
}
    

