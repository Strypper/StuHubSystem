using System.ComponentModel.DataAnnotations.Schema;

namespace StuHubSystem.Core.Entities.EducationSystem
{
    public class StudyField : BaseEntity
    {
        public StudyGroup StudyGroup { get; set; }
        public string StudyFieldName { get; set; }
    }
}
