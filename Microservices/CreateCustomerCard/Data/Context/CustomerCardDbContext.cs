using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace TDonCashless.Microservices.CreateCustomerCard.Data.Context
{
    public class CustomerCardDbContext : DbContext
    {
        public CustomerCardDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerCard> CustomerCards { get; set; }
    }
}