using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DAL.Entities;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("VacabularyConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Language>().ToTable("Language");
            modelBuilder.Entity<Word>().ToTable("Word");
            modelBuilder.Entity<Translation>().ToTable("Translation");
        }
    }
}
