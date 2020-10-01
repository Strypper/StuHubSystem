using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StuHubSystem.Core.Entities.EducationSystem
{
    public class StudyField
    {
        [Key]
        public int StudyFieldId { get; set; }
        [Required]
        public StudyGroup StudyGroupID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string StudyFieldName { get; set; }
    }
}
