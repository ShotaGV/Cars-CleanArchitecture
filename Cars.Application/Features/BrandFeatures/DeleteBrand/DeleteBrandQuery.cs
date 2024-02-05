using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.DeleteBrand
{
    public class DeleteBrandQuery : IRequest
    {
        public Guid Id { get; set; }
    }
}
