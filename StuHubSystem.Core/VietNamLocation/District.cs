using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuHubSystem.Core.VietNamLocation
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        public City CityID { get; set; }
        public string DistrictName { get; set; }
    }
}
