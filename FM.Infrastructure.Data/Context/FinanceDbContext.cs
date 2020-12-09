using FM.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FM.Infrastructure.Data.Context
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<Website> Website { get; set; }

        public DbSet<Login> Login { get; set; }

        public DbSet<Budget> Budget { get; set; }
    }
}
