using DIExample.Models;
using Microsoft.EntityFrameworkCore;
namespace DIExample.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }  
    }
}
