using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TechAdvocacia.Data {
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
    public ApplicationDbContext CreateDbContext(string[] args) {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TechAdvocacia.WebAPI")) // Ajuste o caminho conforme necessário
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new ApplicationDbContext(builder.Options);
        }
    }
}
