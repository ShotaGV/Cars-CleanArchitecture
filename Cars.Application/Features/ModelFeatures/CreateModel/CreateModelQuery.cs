using Cars.Application.Dtos.ModelDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.CreateModel
{
    public class CreateModelQuery : IRequest<ModelDto>
    {
        public Guid BrandId { get; set; }
        public CreateModelDto createModelDto { get; set; }
    }
}
