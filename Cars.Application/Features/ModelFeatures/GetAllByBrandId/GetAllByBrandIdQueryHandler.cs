using AutoMapper;
using Cars.Application.Dtos.ModelDtos;
using Cars.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.GetAllByBrandId
{
    public class GetAllByBrandIdQueryHandler : IRequestHandler<GetAllByBrandIdQuery, List<ModelDto>>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public GetAllByBrandIdQueryHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        public async Task<List<ModelDto>> Handle(GetAllByBrandIdQuery request, CancellationToken cancellationToken)
        {
            var models = await _modelRepository.GetAllByBrandId(request.BrandId, cancellationToken);
            return _mapper.Map<List<ModelDto>>(models);
        }
    }
}
