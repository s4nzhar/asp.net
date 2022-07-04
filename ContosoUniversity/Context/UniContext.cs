using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Context
{
    public class UniContext : DbContext
    {
        public UniContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        
        
    }
}
