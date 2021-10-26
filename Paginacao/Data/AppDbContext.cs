using Microsoft.EntityFrameworkCore;
using Paginacao.Models;

namespace Paginacao.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "Datasource=app.db;Cache=Shared");

    }
}
