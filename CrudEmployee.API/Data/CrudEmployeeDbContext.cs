// Microsoft Core
using Microsoft.EntityFrameworkCore;

// Models
using CrudEmployee.API.Models;

namespace CrudEmployee.API.Data
{
    public class CrudEmployeeDbContext : DbContext
    {
        public CrudEmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
