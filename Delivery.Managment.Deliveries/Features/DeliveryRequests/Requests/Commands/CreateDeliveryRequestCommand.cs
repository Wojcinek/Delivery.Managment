using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands
{
    public class CreateDeliveryRequestCommand : IRequest<int>
    {
        public CreateDeliveryRequestDto DeliveryRequestDto { get; set; }
    }
}
