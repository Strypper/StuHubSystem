using StuHubSystem.Core.Entities.EducationSystem;
using StuHubSystem.Core.Entities.VietNamLocation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StuHubSystem.Core.Entities.Person
{
    public class UserModel
    {
        public static object Claims { get; internal set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImageUrl { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime DayOfBirth { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string UserAddress { get; set; }
        public City UserCity { get; set; }
        public District UserDistrict { get; set; }
        public StudyGroup StudyGroup { get; set; }
        public StudyField StudyField { get; set; }
        public School School { get; set; }
    }
}
