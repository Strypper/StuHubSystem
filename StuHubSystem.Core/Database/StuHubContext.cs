using Microsoft.EntityFrameworkCore;
using StuHubSystem.Core.Entities.EducationSystem;
using StuHubSystem.Core.Entities.Subjects.College;
using StuHubSystem.Core.Entities.VietNamLocation;

namespace StuHubSystem.Core.Database
{
    public class StuHubContext : DbContext
    {
        public StuHubContext(DbContextOptions<StuHubContext> options) : base(options) { }
        public DbSet<CollegeSubject> CollegeSubjects { get; set; }
        public DbSet<CollegeSubjectRequest> CollegeSubjectRequests { get; set; }
        public DbSet<StudyGroup> StudyGroups { get; set; }
        public DbSet<StudyField> StudyFields { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {

        }
    }
}
