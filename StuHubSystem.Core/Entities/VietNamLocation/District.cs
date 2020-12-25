
namespace StuHubSystem.Core.Entities.VietNamLocation
{
    public class District : BaseEntity
    {
        public City City { get; set; }
        public string DistrictName { get; set; }
    }
}
