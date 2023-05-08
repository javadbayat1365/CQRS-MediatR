using MediatR_CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatR_CQRS.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
       
    }
}
