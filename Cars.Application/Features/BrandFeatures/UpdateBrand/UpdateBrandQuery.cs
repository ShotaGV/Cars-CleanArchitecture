using Cars.Application.Dtos.BrandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.UpdateBrand
{
    public class UpdateBrandQuery : IRequest<BrandDto>
    {
        public Guid Id { get; set; }
        public UpdateBrandDto updateBrandDto { get; set; }
    }
}
