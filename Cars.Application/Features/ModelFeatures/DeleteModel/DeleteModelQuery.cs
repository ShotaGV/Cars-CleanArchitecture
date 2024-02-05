using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Features.ModelFeatures.DeleteModel
{
    public class DeleteModelQuery : IRequest
    {
        public Guid Id { get; set; }
    }
}
