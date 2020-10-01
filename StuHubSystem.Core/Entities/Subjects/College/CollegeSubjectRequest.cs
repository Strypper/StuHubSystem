using StuHubSystem.Core.Entities.EducationSystem;
using StuHubSystem.Core.Entities.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuHubSystem.Core.Entities.Subjects.College
{
    public class CollegeSubjectRequest
    {
        [Key]
        public int CollegeSubjectId { get; set; }
        public UserModel Owner { get; set; }
        public string CollegeSubjectName { get; set; }
        public DateTime DateUpload { get; set; }
        public StudyGroup StudyGroupID { get; set; }
        public StudyField StudyFieldID { get; set; }
        public string Teacher { get; set; }
        public School SchoolID { get; set; }
    }
}
