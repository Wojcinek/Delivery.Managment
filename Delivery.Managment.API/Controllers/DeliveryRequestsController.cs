using System.Reflection.Metadata.Ecma335;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Delivery.Managment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryRequestsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DeliveryRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<DeliveryRequestsController>
        [HttpGet]
        public async Task<ActionResult<List<DeliveryRequestDto>>> Get()
        {
            var deliveryRequests = await _mediator.Send(new GetDeliveryRequestListRequest());
            return Ok(deliveryRequests);
        }

        // GET api/<DeliveryRequestsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryRequestDto>> Get(int id)
        {
            var deliveryRequest = await _mediator.Send(new GetDeliveryRequestDetailRequest { Id = id });
            return Ok(deliveryRequest);
        }

        // POST api/<DeliveryRequestsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateDeliveryRequestDto deliveryRequest)
        {
            var command = new CreateDeliveryRequestCommand { DeliveryRequestDto = deliveryRequest };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<DeliveryRequestsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateDeliveryRequestDto deliveryRequest)
        {
            var command = new UpdateDeliveryRequestCommand { Id = id, DeliveryRequestDto = deliveryRequest };
            await _mediator.Send(command);
            return NoContent();
        }

        // PUT api/<DeliveryRequestsController>/changesent/5
        [HttpPut("changesent/{id}")]
        public async Task<ActionResult> ChangeSent(int id, [FromBody] ChangeDeliveryRequestSentDto changeDeliveryRequestSent)
        {
            var command = new UpdateDeliveryRequestCommand { ChangeDeliveryRequestSentDto = changeDeliveryRequestSent };
            await _mediator.Send(command);
            return Ok(command);
        }

        // DELETE api/<DeliveryRequestsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteDeliveryRequestCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
