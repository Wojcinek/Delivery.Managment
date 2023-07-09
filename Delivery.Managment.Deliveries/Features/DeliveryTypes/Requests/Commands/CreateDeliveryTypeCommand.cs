using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryType;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Commands
{
    public class CreateDeliveryTypeCommand : IRequest<int>
    {
        public CreateDeliveryTypeDto DeliveryTypeDto { get; set; }
    }
}
