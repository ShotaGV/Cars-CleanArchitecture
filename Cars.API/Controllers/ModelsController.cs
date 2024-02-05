using Cars.Application.Dtos.ModelDtos;
using Cars.Application.Features.ModelFeatures.CreateModel;
using Cars.Application.Features.ModelFeatures.DeleteModel;
using Cars.Application.Features.ModelFeatures.GetAllByBrandId;
using Cars.Application.Features.ModelFeatures.GetByIdModel;
using Cars.Application.Features.ModelFeatures.UpdateModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ModelsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllByBrandId(Guid brandId, CancellationToken cancellationToken)
        {
            var command = new GetAllByBrandIdQuery { BrandId = brandId };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ModelDto>> GetById(Guid id, CancellationToken cancellationToken)
        {
            var command = new GetByIdModelQuery { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpPost("{brandId}")]
        public async Task<IActionResult> Create(Guid brandId, [FromBody] CreateModelDto createModelDto, CancellationToken cancellationToken)
        {
            var command = new CreateModelQuery
            {
                BrandId = brandId,
                createModelDto = createModelDto
            };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateModelDto updateModelDto, CancellationToken cancellationToken)
        {
            var command = new UpdateModelQuery
            {
                Id = id,
                updateModelDto = updateModelDto
            };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteModelQuery { Id = id };
            var response = await _mediator.Send(command);
            return NoContent();
        }
    }
}
