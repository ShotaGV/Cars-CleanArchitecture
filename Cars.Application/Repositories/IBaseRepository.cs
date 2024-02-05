using Cars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
    }
}
