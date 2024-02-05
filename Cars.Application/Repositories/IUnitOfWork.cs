using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Repositories
{
    public interface IUnitOfWork
    {
        Task Save(CancellationToken cancellationToken);
    }
}
