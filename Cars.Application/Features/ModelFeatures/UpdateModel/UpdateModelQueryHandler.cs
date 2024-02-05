using AutoMapper;
using Cars.Application.Common.Exceptions;
using Cars.Application.Dtos.ModelDtos;
using Cars.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.UpdateModel
{
    public class UpateModelQueryHandler : IRequestHandler<UpdateModelQuery, ModelDto>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpateModelQueryHandler(IModelRepository modelRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ModelDto> Handle(UpdateModelQuery request, CancellationToken cancellationToken)
        {
            var model = await _modelRepository.Get(request.Id, cancellationToken);
            if (model == null)
            {
                throw new ModelNotFoundException(request.Id);
            }
            _mapper.Map(request.updateModelDto, model);
            _modelRepository.Update(model);
            await _unitOfWork.Save(cancellationToken);
            return _mapper.Map<ModelDto>(model);
        }
    }
}
