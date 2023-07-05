using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands
{
    public class UpdateDeliveryRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeliveryRequestDto DeliveryRequestDto { get; set; }

        public ChangeDeliveryRequestSentDto ChangeDeliveryRequestSentDto { get; set;}
    }
}
