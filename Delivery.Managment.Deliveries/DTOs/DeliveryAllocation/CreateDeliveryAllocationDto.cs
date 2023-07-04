using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.Common;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryAllocation
{
    public class CreateDeliveryAllocationDto : BaseDto
    {
        public int DeliveryTypeId { get; set; }
        public string Warehouse { get; set; }
    }
}
