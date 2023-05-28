using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyAppWeb.Models;
using System.Data;

namespace MyAppWeb.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> databaseContextOption) :
            base(databaseContextOption)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
