using Microsoft.EntityFrameworkCore;

namespace MVC_Attendance.Models
{
    public class AttDbContext : DbContext
    {
        public AttDbContext(DbContextOptions<AttDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().UseTptMappingStrategy();
        }
    }
}
