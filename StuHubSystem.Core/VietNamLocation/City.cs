using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StuHubSystem.Core.VietNamLocation
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
