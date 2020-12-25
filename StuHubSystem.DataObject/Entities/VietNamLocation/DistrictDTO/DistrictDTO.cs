using StuHubSystem.DataObject.Entities.VietNamLocation.CityDTO;

namespace StuHubSystem.DataObject.Entities.VietNamLocation.DistrictDTO
{
    public class DistrictDTO : BaseDTO
    {
        public CityDTO.CityDTO City { get; set; }
        public string DistrictName { get; set; }
    }
}
