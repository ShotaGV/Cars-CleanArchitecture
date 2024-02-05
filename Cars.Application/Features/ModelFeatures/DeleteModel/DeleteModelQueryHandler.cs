using AutoMapper;
using Cars.Application.Common.Exceptions;
using Cars.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.DeleteModel
{
    public class DeleteModelQueryHandler : IRequestHandler<DeleteModelQuery>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteModelQueryHandler(IModelRepository modelRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteModelQuery request, CancellationToken cancellationToken)
        {
            var model = await _modelRepository.Get(request.Id, cancellationToken);
            if (model == null)
            {
                throw new BrandNotFoundException(request.Id);
            }
            _modelRepository.Delete(model);
            await _unitOfWork.Save(cancellationToken);

            return Unit.Value;
        }
    }
}
