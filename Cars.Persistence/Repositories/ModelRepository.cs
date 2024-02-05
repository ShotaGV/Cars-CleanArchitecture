using Cars.Application.Repositories;
using Cars.Domain.Entities;
using Cars.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistence.Repositories
{
    public class ModelRepository : BaseRepository<Model>, IModelRepository
    {
        public ModelRepository(DataContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Model>> GetAllByBrandId(Guid brandId, CancellationToken cancellationToken) =>
            await _dbContext.Models.Where(m => m.BrandId == brandId).ToListAsync(cancellationToken);
    }
}
