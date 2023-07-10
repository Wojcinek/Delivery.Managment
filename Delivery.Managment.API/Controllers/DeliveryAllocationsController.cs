using Delivery.Managment.Deliveries.DTOs.DeliveryAllocation;
using Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Commands;
using Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Delivery.Managment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryAllocationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DeliveryAllocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<DeliveryAllocationController>
        [HttpGet]
        public async Task<ActionResult<List<DeliveryAllocationDto>>> Get()
        {
            var deliveryAllocations = await _mediator.Send(new GetDeliveryAllocationListRequest());
            return Ok(deliveryAllocations);
        }

        // GET api/<DeliveryAllocationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryAllocationDto>> Get(int id)
        {
            var deliveryAllocation = await _mediator.Send(new GetDeliveryAllocationDetailRequest { Id = id });
            return Ok(deliveryAllocation);
        }

        // POST api/<DeliveryAllocationController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateDeliveryAllocationDto deliveryAllocation)
        {
            var command = new CreateDeliveryAllocationCommand { DeliveryAllocationDto = deliveryAllocation };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        // PUT api/<DeliveryAllocationController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateDeliveryAllocationDto deliveryAllocation)
        {
            var command = new UpdateDeliveryAllocationCommand { DeliveryAllocationDto = deliveryAllocation };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<DeliveryAllocationController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteDeliveryAllocationCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
