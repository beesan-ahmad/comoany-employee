using Microsoft.EntityFrameworkCore;
using task3.Mdels;

namespace task3
{
    public class EFContext: DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PNEVQP5\SQLEXPRESS01;Database=Training;Trusted_Connection=True;");
            
        }
    }
}
