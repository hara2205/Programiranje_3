using FIT.Data;
using FIT.Data.ispit;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<prostorija> Prostorije {get; set; }
        public DbSet<semestar> Semestri {  get; set; }
        public DbSet<predmet> Predmeti { get; set; }
        public DbSet<nastava> Nastava { get; set; }
        public DbSet<prisustvo>Prisustvo { get; set; }
    }
}