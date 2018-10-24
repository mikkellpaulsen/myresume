using Microsoft.EntityFrameworkCore;
using Model;

namespace DB
{
    public class CvContext : DbContext
    {
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Internship> Internships { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ThirdPartLibary> ThirdPartLibaries { get; set; }
        public DbSet<WorkTool> Worktools { get; set; }
   
    }
}