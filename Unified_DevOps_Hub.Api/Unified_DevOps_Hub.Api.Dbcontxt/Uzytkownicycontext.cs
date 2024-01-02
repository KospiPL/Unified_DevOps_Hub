using Microsoft.EntityFrameworkCore;
using Unified_DevOps_Hub.Api.Controllers;
using Microsoft.Extensions.Configuration;

namespace Unified_DevOps_Hub.Api.Unified_DevOps_Hub.Api.Dbcontxt
{
    public class UzytkownicyContext : DbContext
    {
        public DbSet<Uzytkownicy> Uzytkownicy { get; set; }

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
    }
}
