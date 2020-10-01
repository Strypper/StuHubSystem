using StuHubSystem.Core.VietNamLocation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuHubSystem.Core.Entities.EducationSystem
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }
        public string SchoolLogoUrl { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolInfo { get; set; }
        public string SchoolBackgroundImages { get; set; }
        public int GirlPercentage { get; set; }
        public int BoyPercentage { get; set; }
        public City CityID { get; set; }
        public District DistrictID { get; set; }
    }
}
