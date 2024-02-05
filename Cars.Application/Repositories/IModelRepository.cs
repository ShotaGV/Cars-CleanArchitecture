using Cars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Repositories
{
    public interface IModelRepository : IBaseRepository<Model>
    {
        Task<List<Model>> GetAllByBrandId(Guid id, CancellationToken cancellationToken);
    }
}
