using StuHubSystem.DataObject.Entities.Subjects.College.CollegeSubjectDTO;
using StuHubSystem.DataObject.Entities.VietNamLocation.CityDTO;
using StuHubSystem.DataObject.Entities.VietNamLocation.DistrictDTO;
using System;

namespace StuHubSystem.DataObject.Entities.Subjects.College.CollegeSubjectRequestDTO
{
    public class BaseCollegeSubjectRequestDTO : BaseDTO
    {
        public BaseCollegeSubjectDTO CollegeSubject { get; set; }
        public DateTime DateUpdload { get; set; }
        public decimal Price { get; set; }
        public string Teacher { get; set; } = String.Empty;
        public bool HomeWork { get; set; }
        public bool Presentation { get; set; }
        public bool Laboratory { get; set; }
        public CityDTO LearningCity { get; set; }
        public DistrictDTO LearningDistrict { get; set; }
        public PaymentTimeTypeDTO PaymentTimeType { get; set; }
    }

    public enum PaymentTimeTypeDTO
    {
        Hour = 0,
        Week = 1,
        Month = 2,
        Custom = 3
    }
}
