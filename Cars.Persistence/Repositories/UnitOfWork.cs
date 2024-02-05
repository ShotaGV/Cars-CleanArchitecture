using Cars.Application.Repositories;
using Cars.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dbContext;

        public UnitOfWork(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Save(CancellationToken cancellationToken) =>
            _dbContext.SaveChangesAsync(cancellationToken);

    }

}
