using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class CustomerCardDbContext : DbContext
    {
        public CustomerCardDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerCard> CustomerCards { get; set; }
    }
}