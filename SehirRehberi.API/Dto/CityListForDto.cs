using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Dto
{
    public class CityListForDto
    {
        public int CityId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

    }
}
