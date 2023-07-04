using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.Common;
using Delivery.Managment.Deliveries.DTOs.DeliveryType;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryRequest
{
    public class CreateDeliveryRequestDto : BaseDto
    {
        public DateTime ShipDate { get; set; }
        public DeliveryTypeDto DeliveryType { get; set; }
        public int DeliveryTypeId { get; set; }
        public string RequestComments { get; set; }

    }
}
