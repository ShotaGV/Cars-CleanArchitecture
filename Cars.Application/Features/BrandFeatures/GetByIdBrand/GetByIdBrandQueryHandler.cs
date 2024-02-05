using AutoMapper;
using Cars.Application.Common.Exceptions;
using Cars.Application.Dtos.BrandDtos;
using Cars.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.GetByIdBrand
{
    public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, BrandDto>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByIdBrandQueryHandler(IBrandRepository brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BrandDto> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.Get(request.Id, cancellationToken);
            if (brand == null)
            {
                throw new BrandNotFoundException(request.Id);
            }
            return _mapper.Map<BrandDto>(brand);
        }
    }
}
