using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Common.Exceptions
{
    public sealed class ModelNotFoundException : NotFoundException
    {
        public ModelNotFoundException(Guid modelId)
            : base($"Model: {modelId} was not found")
        {
        }
    }
}
