using EFCDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCData.Context
{
    public sealed class EFCContext : DbContext
    {
        public EFCContext(DbContextOptions<EFCContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}