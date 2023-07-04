using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryAllocation;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Queries
{
    public class GetDeliveryAllocationDetailRequest : IRequest<DeliveryAllocationDto>
    {
        public int Id { get; set; }
    }
}
