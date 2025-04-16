using EmployeeManagnmentSystem_Backend.Entity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagnmentSystem_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }  // ✅ Property definition is correct
        public DbSet<Department>Departments { get; set; }
    }
}
