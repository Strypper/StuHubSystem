﻿using Microsoft.AspNetCore.Identity;
using StuHubSystem.Core.Entities.EducationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StuHubSystem.Core.Entities.Person
{
    public class UserModel : IdentityUser<int>
    {
        public static object Claims { get; internal set; }
        [NotMapped]
        public string Pass { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string LastName { get; set; }
        [Required]
        public string ProfileImageUrl { get; set; }
        public string CoverImageUrl { get; set; }
        [Column(TypeName = "date")]
        public DateTime DayOfBirth { get; set; }
        [Column(TypeName = "bit")]
        public bool Gender { get; set; }
        [Required]
        [Range(18, 60, ErrorMessage = "Your Age Must Older Than 18")]
        [Column(TypeName = "tinyint")]
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserAddress { get; set; }
        [ForeignKey("CityID")]
        public int UserCity { get; set; }
        [ForeignKey("DistrictID")]
        public int UserDistrict { get; set; }
        [ForeignKey("StudyGroupID")]
        public StudyGroup StudyGroup { get; set; }
        [ForeignKey("StudyFieldID")]
        public StudyField StudyField { get; set; }
        [ForeignKey("SchoolID")]
        public int SchoolID { get; set; }
    }
}
