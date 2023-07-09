using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryAllocation;
using Delivery.Managment.Deliveries.Responses;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Commands
{
    public class CreateDeliveryAllocationCommand : IRequest<BaseCommandResponse>
    {
        public CreateDeliveryAllocationDto DeliveryAllocationDto { get; set; }
    }
}
