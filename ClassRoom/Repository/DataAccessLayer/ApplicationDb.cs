using ClassRoom.Module.Entity;
using Microsoft.EntityFrameworkCore;

namespace ClassRoom.Repository.DataAccessLayer
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }

    }
}
