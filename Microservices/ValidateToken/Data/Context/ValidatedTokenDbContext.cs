using Microsoft.EntityFrameworkCore;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Data.Context
{
    public class ValidatedTokenDbContext : DbContext
    {
        public ValidatedTokenDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ValidatedToken> ValidatedTokens { get; set; }
    }
}