using Cars.Application.Dtos.BrandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.GetAllBrand
{
    public class GetAllBrandQuery : IRequest<IEnumerable<BrandDto>>
    {
    }
}
