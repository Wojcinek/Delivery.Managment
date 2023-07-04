using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryAllocation;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Commands
{
    public class UpdateDeliveryAllocationCommand : IRequest<Unit>
    {
        public UpdateDeliveryAllocationCommand DeliveryAllocationDto { get; set; }
    }
}
