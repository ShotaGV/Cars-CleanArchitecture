using Cars.Application.Dtos.BrandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.CreateBrand
{
    public class CreateBrandQuery : IRequest<BrandDto>
    {
        public CreateBrandDto createBrandDto { get; set; }
    }
}
