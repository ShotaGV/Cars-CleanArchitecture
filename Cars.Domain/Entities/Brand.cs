using Cars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public int BrandCreatedYear { get; set; }
        public bool? StillExists { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}
