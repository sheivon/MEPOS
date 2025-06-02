using Microsoft.EntityFrameworkCore;

namespace Marshell_Admin
{
    public class ApplicationDBContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; } // The Users table
    } 
