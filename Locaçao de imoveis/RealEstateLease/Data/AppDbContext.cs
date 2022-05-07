using Microsoft.EntityFrameworkCore;
using RealEstateLease.Models;

namespace RealEstateLease.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opitions) : base (opitions)
        {

        }

        public DbSet<Imovel> Imoveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imovel>()
                .Property(i => i.Proprietario)
                .HasMaxLength(80);

            modelBuilder.Entity<Imovel>()
                .Property(i => i.Endereço)
                .HasMaxLength(100);

            modelBuilder.Entity<Imovel>()
                .Property(i => i.Cep)
                .HasMaxLength(9);

            modelBuilder.Entity<Imovel>()
                .Property(i => i.Telefone)
                .HasMaxLength(15);

            modelBuilder.Entity<Imovel>()
                .Property(i => i.ValorDoAluguel)
                .HasPrecision(10,2);

            
        }
    }
}
