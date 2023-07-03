﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests
{
    public class GetDeliveryTypeDetailRequest : IRequest<DeliveryTypeDto>
    {
        public int Id { get; set; }
    }
}
