using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.Common;
using Delivery.Managment.Domain;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryRequest
{
    public class DeliveryRequestDto : BaseDto
    {
        public DateTime ShipDate { get; set; }
        public DeliveryTypeDto DeliveryType { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public int DeliveryTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool? Sent { get; set; }
        public bool Cancelled { get; set; }
    }
}
