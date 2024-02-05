using Cars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public int ManufactureStartDate { get; set; }
        public int ManufactureEndDate { get; set; }
        public Brand Brand { get; set; }
    }
}
