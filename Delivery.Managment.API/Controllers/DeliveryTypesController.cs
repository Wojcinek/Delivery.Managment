using Delivery.Managment.Deliveries.DTOs.DeliveryType;
using Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Commands;
using Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Delivery.Managment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryTypesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DeliveryTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<DeliveryTypesController>
        [HttpGet]
        public async Task<ActionResult<List<DeliveryTypeDto>>> Get()
        {
            var deliveryTypes = await _mediator.Send(new GetDeliveryTypeListRequest());
            return deliveryTypes;
        }

        // GET api/<DeliveryTypesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryTypeDto>> Get(int id)
        {
            var deliveryType = await _mediator.Send(new GetDeliveryTypeDetailRequest { Id = id });
            return Ok(deliveryType);
        }

        // POST api/<DeliveryTypesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateDeliveryTypeDto deliveryType)
        {
            var command = new CreateDeliveryTypeCommand { DeliveryTypeDto = deliveryType };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<DeliveryTypesController>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] DeliveryTypeDto deliveryType)
        {
            var command = new UpdateDeliveryTypeCommand { DeliveryTypeDto = deliveryType };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<DeliveryTypesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteDeliveryTypeCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
