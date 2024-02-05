using Cars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Repositories
{
    public interface IBrandRepository : IBaseRepository<Brand>
    {
        Task<IEnumerable<Brand>> GetAllBrand(CancellationToken cancellationToken);
    }
}
