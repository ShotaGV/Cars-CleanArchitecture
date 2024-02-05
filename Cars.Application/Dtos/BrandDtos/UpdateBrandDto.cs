using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Dtos.BrandDtos
{
    public class UpdateBrandDto
    {
        public string Name { get; set; }
        public int BrandCreatedYear { get; set; }
        public bool? StillExists { get; set; }
    }
}
