﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.Common;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryType
{
    public class CreateDeliveryTypeDto : IDeliveryTypeDto
    {
        public string Name { get; set; }
    }
}
