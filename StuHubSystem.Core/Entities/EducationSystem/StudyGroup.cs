using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuHubSystem.Core.Entities.EducationSystem
{
    public class StudyGroup
    {
        [Key]
        public int StudyGroupId { get; set; }
        public string StudyGroupName { get; set; }
        public string StudyGroupImageUrl { get; set; }
        public string StudyGroupColor { get; set; }
    }
}
