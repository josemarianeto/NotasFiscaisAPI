using Microsoft.EntityFrameworkCore;
using NotasFiscaisAPI.Models;

namespace NotasFiscaisAPI.Data
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Notas");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Items> Items { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
