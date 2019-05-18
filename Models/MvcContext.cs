using Microsoft.EntityFrameworkCore;

namespace demomvc.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        public DbSet<demomvc.Models.Student> Student { get; set; }

        public DbSet<demomvc.Models.Teacher> Teacher { get; set; }
    }
}