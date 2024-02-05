using Cars.Application.Dtos.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Dtos.BrandDtos
{
    public class BrandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int BrandCreatedYear { get; set; }
        public bool? StillExists { get; set; }
        public IEnumerable<ModelDto> Models { get; set; }

    }
}
