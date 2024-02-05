using Cars.Application.Dtos.ModelDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.UpdateModel
{
    public class UpdateModelQuery : IRequest<ModelDto>
    {
        public Guid Id { get; set; }
        public UpdateModelDto updateModelDto { get; set; }
    }
}
