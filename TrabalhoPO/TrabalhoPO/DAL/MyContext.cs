using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using TrabalhoPO.Models;

namespace TrabalhoPO.DAL
{
    public class MyContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public MyContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrabalhoPO;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }

        public decimal GetNextId(string set)
        {
            return Database.SqlQuery<decimal>("SELECT ISNULL(IDENT_CURRENT('" + set + "') + IDENT_INCR('" + set + "'), 1)").FirstOrDefault();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Usuario>().Ignore(x => x.ConfirmarSenha);
        }
    }
}
