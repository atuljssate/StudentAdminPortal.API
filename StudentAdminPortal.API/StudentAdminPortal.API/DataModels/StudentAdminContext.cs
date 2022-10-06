using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext : DbContext
    {
        //protected readonly IConfiguration _configuration;

        //public StudentAdminContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer(_configuration.GetConnectionString("StudentAdminPortalDb"));
        //}
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
