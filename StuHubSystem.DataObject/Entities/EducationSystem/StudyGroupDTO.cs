using System;

namespace StuHubSystem.DataObject.Entities.EducationSystem
{
    public class StudyGroupDTO : BaseDTO
    {
        public string StudyGroupName { get; set; } = String.Empty;
        public string StudyGroupImageUrl { get; set; } = String.Empty;
        public string StudyGroupColor { get; set; } = String.Empty;
    }
}
