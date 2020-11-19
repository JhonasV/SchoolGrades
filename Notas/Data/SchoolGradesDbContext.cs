using Microsoft.EntityFrameworkCore;

namespace SchoolGrades.Data
{
    public class SchoolGradesDbContext : DbContext
    {
        public SchoolGradesDbContext(DbContextOptions<SchoolGradesDbContext> options)
            :base(options)
        {

        }

        public DbSet<SchoolGrades.Models.SchoolGrades> SchoolGrades { get; set; }
    }
}
