using StuHubSystem.Core.Entities.VietNamLocation;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StuHubSystem.Core.Entities.Subjects.College
{
    public class CollegeSubjectRequest : BaseEntity
    {
        //public UserModel Owner { get; set; }
        public CollegeSubject CollegeSubject { get; set; }
        public DateTime DateUpload { get; set; }
        public decimal Price { get; set; }
        public string Teacher { get; set; }
        public bool HomeWork { get; set; }
        public bool Presentation { get; set; }
        public bool Laboratory { get; set; }
        public City LearningCity { get; set; }
        public District LearningDistrict { get; set; }
        public PaymentTimeType PaymentTimeType { get; set; }
    }

    public enum PaymentTimeType
    {
        Hour = 0,
        Week = 1,
        Month = 2,
        Custom = 3
    }
}
