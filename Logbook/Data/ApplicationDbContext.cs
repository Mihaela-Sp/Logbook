using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LogBook.Models;

namespace LogBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LogBook.Models.Student> Student { get; set; }
        public DbSet<LogBook.Models.Lesson> Lesson { get; set; }
        public DbSet<LogBook.Models.Mark> Mark { get; set; }
    }
}