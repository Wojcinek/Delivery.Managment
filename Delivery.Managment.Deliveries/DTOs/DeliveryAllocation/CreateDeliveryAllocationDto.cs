using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.Common;
using Delivery.Managment.Deliveries.DTOs.DeliveryType;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryAllocation
{
    public class CreateDeliveryAllocationDto : IDeliveryAllocationDto
    {
        public DeliveryTypeDto DeliveryType { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Warehouse { get; set; }
    }
}
