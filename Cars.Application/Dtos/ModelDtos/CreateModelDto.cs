using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Dtos.ModelDtos
{
    public class CreateModelDto
    {
        public string Name { get; set; }
        public int ManufactureStartDate { get; set; }
        public int ManufactureEndDate { get; set; }
    }
}
