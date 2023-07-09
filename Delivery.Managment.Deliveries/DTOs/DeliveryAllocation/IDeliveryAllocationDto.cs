using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryType;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryAllocation
{
    public interface IDeliveryAllocationDto
    {
        public DeliveryTypeDto DeliveryType { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Warehouse { get; set; }
    }
}
