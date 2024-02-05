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
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(DataContext dbcontext) : base(dbcontext)
        {
        }
        public async Task<IEnumerable<Brand>> GetAllBrand(CancellationToken cancellationToken) =>
            await _dbContext.Brands.Include(x => x.Models).ToListAsync(cancellationToken);
    }
}
