using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.Common;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryRequest
{
    public class ChangeDeliveryRequestSentDto : BaseDto
    {
        public bool? Sent { get; set; }
    }
}
