using AutoMapper;
using Cars.Application.Dtos.ModelDtos;
using Cars.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.GetByIdModel
{
    public class GetByIdModelQueryHandler : IRequestHandler<GetByIdModelQuery, ModelDto>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public GetByIdModelQueryHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }
        public async Task<ModelDto> Handle(GetByIdModelQuery request, CancellationToken cancellationToken)
        {
            var model = await _modelRepository.Get(request.Id, cancellationToken);
            if (model == null)
            {
                throw new ModelNotFoundException(request.Id);
            }
            return _mapper.Map<ModelDto>(model);
        }
    }
}
