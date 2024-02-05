using AutoMapper;
using Cars.Application.Common.Exceptions;
using Cars.Application.Dtos.ModelDtos;
using Cars.Application.Repositories;
using Cars.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.CreateModel
{
    public class CreateModelQueryHandler : IRequestHandler<CreateModelQuery, ModelDto>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateModelQueryHandler(IModelRepository modelRepository, IBrandRepository brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ModelDto> Handle(CreateModelQuery request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.Get(request.BrandId, cancellationToken);
            if (brand == null)
            {
                throw new BrandNotFoundException(request.BrandId);
            }
            var model = _mapper.Map<Model>(request.createModelDto);
            model.Brand = brand;
            _modelRepository.Create(model);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<ModelDto>(model);
        }
    }
}
