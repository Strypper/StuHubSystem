using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StuHubSystem.Core.Entities.EducationSystem;
using StuHubSystem.Core.Entities.Person;
using StuHubSystem.Core.Entities.Subjects.College;
using StuHubSystem.Core.VietNamLocation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuHubSystem.Core.Database
{
    public class StuHubContext : IdentityDbContext<UserModel, IdentityRole<int>, int>
    {
        public StuHubContext(DbContextOptions<StuHubContext> options) : base(options) { }
        public DbSet<CollegeSubjectRequest> CollegeSubjectRequests { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<StudyGroup> StudyGroups { get; set; }
        public DbSet<StudyField> StudyFields { get; set; }
    }
}
