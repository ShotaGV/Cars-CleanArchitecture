using Cars.Application.Dtos.BrandDtos;
using Cars.Application.Features.BrandFeatures.CreateBrand;
using Cars.Application.Features.BrandFeatures.DeleteBrand;
using Cars.Application.Features.BrandFeatures.GetAllBrand;
using Cars.Application.Features.BrandFeatures.GetByIdBrand;
using Cars.Application.Features.BrandFeatures.UpdateBrand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BrandDto>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllBrandQuery(), cancellationToken);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BrandDto>> GetById(Guid id, CancellationToken cancellationToken)
        {
            var command = new GetByIdBrandQuery { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBrandDto createBrandDto, CancellationToken cancellationToken)
        {
            var command = new CreateBrandQuery { createBrandDto = createBrandDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateBrandDto updateBrandDto, CancellationToken cancellationToken)
        {
            var command = new UpdateBrandQuery
            {
                Id = id,
                updateBrandDto = updateBrandDto
            };
            var response = await _mediator.Send(command);
            return Ok(command);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteBrandQuery { Id = id };
            var response = await _mediator.Send(command);
            return NoContent();
        }
    }
}
