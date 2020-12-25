using System;
using System.Collections.Generic;
using System.Text;

namespace StuHubSystem.DataObject.Entities.EducationSystem
{
    public class StudyFieldDTO : BaseDTO
    {
        public string StudyFieldName { get; set; } = String.Empty;
        public StudyGroupDTO StudyGroup { get; set; }
    }
}
