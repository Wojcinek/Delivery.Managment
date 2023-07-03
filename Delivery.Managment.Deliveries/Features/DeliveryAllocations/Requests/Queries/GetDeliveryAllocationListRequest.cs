using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Queries
{
    public class GetDeliveryAllocationListlRequest : IRequest<List<DeliveryAllocationDto>>
    {

    }
}
