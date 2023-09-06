using Microsoft.EntityFrameworkCore;
using CoreMvcCodeFirst.Models;

namespace CoreMvcCodeFirst.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CoreMvcCodeFirst.Models.Register>? Register { get; set; }
    }
}
