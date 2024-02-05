using Cars.Application.Dtos.ModelDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.GetByIdModel
{
    public class GetByIdModelQuery : IRequest<ModelDto>
    {
        public Guid Id { get; set; }
    }
}
