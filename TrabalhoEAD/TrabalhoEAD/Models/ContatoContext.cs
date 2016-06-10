using System.Data.Entity;

namespace Contatos.Models
{
    public class ContatoContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public ContatoContext() : base("ContatoContext")
        {
            Database.SetInitializer<ContatoContext>(new CreateDatabaseIfNotExists<ContatoContext>());
        }
    }
}