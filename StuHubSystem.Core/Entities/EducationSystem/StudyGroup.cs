using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuHubSystem.Core.Entities.EducationSystem
{
    public class StudyGroup : BaseEntity
    {
        public string StudyGroupName { get; set; }
        public string StudyGroupImageUrl { get; set; }
        public string StudyGroupColor { get; set; }
    }
}
