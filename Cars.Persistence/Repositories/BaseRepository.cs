using Cars.Application.Repositories;
using Cars.Domain.Common;
using Cars.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DataContext _dbContext;
        public BaseRepository(DataContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public void Create(T entity) => _dbContext.Add(entity);

        public void Delete(T entity) => _dbContext.Remove(entity);

        public void Update(T entity) => _dbContext.Update(entity);

        public async Task<T> Get(Guid id, CancellationToken cancellationToken) =>
            await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken) =>
            await _dbContext.Set<T>().ToListAsync(cancellationToken);

    }
}
