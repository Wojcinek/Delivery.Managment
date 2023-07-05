using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Commands
{
    public class DeleteDeliveryTypeCommand : IRequest
    {
        public int Id { get; set; } 
    }
}
