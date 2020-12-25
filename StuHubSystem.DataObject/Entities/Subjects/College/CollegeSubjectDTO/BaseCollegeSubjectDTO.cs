using StuHubSystem.DataObject.Entities.EducationSystem;
using System;

namespace StuHubSystem.DataObject.Entities.Subjects.College.CollegeSubjectDTO
{
    public class BaseCollegeSubjectDTO : BaseDTO
    {
        public string SubjectRequest { get; set; } = String.Empty;
        public StudyGroupDTO StudyGroup { get; set; }
        public StudyFieldDTO StudyField { get; set; }
    }
}
