
using StuHubSystem.Core.Entities.VietNamLocation;

namespace StuHubSystem.Core.Entities.EducationSystem
{
    public class School : BaseEntity
    {
        public string SchoolLogoUrl { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolInfo { get; set; }
        public string SchoolBackgroundImages { get; set; }
        public int GirlPercentage { get; set; }
        public int BoyPercentage { get; set; }
        public City City { get; set; }
        public District District { get; set; }
    }
}
