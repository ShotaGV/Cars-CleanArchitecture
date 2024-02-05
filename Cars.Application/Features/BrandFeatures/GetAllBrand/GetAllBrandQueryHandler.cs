using AutoMapper;
using Cars.Application.Dtos.BrandDtos;
using Cars.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.GetAllBrand
{
    public class GetAllBrandQueryHandler : IRequestHandler<GetAllBrandQuery, IEnumerable<BrandDto>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllBrandQueryHandler(IBrandRepository brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BrandDto>> Handle(GetAllBrandQuery request, CancellationToken cancellationToken)
        {
            var brands = await _brandRepository.GetAllBrand(cancellationToken);
            return _mapper.Map<IEnumerable<BrandDto>>(brands);
        }
    }
}
