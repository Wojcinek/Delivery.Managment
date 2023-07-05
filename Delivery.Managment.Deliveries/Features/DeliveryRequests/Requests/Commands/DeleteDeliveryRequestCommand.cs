using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands
{
    public class DeleteDeliveryRequestCommand : IRequest
    {
        public int Id { get; set; } 
    }
}
