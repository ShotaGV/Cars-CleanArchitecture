using AutoMapper;
using Cars.Application.Dtos.BrandDtos;
using Cars.Application.Repositories;
using Cars.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.CreateBrand
{
    public class CreateBrandQueryHandler : IRequestHandler<CreateBrandQuery, BrandDto>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBrandQueryHandler(IBrandRepository brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BrandDto> Handle(CreateBrandQuery request, CancellationToken cancellationToken)
        {
            var brand = _mapper.Map<Brand>(request.createBrandDto);
            _brandRepository.Create(brand);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<BrandDto>(brand);
        }
    }
}
