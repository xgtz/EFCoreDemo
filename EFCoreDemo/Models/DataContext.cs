using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Models
{
    public class DataContext:DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
