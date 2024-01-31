using Microsoft.EntityFrameworkCore;
using TechAdvocacia.Core.Models;

namespace TechAdvocacia.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            // Configurações da entidade Advogado
            modelBuilder.Entity<Advogado>(entity => {
                entity.ToTable("Advogados");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.CPF).IsRequired().HasMaxLength(11);
                entity.Property(e => e.CNA).HasMaxLength(20);
            });

            // Configurações da entidade Cliente
            modelBuilder.Entity<Cliente>(entity => {
                entity.ToTable("Clientes");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Nome).IsRequired().HasMaxLength(150);
            });
        }
    }
}
