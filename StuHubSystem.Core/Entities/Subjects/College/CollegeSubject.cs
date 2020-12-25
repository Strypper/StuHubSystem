using StuHubSystem.Core.Entities.EducationSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuHubSystem.Core.Entities.Subjects.College
{
    public class CollegeSubject : BaseEntity
    {
        public string SubjectName { get; set; }
        public StudyGroup StudyGroup { get; set; }
        public StudyField StudyField { get; set; }
        public School School { get; set; }
    }
}
