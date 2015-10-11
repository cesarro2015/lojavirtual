using System.Data.Entity;
using portifolio.LojaVirtual.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace portifolio.LojaVirtual.Dominio.Repositorio
{
    public class LJDbcontext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
