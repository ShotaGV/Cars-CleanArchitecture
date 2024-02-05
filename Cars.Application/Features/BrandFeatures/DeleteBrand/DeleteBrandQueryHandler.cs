using AutoMapper;
using Cars.Application.Common.Exceptions;
using Cars.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.BrandFeatures.DeleteBrand
{
    public class DeleteBrandQueryHandler : IRequestHandler<DeleteBrandQuery>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteBrandQueryHandler(IBrandRepository brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteBrandQuery request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.Get(request.Id, cancellationToken);
            if (brand == null)
            {
                throw new BrandNotFoundException(request.Id);
            }
            _brandRepository.Delete(brand);
            await _unitOfWork.Save(cancellationToken);

            return Unit.Value;
        }
    }
}
