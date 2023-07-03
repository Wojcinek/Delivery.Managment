using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Domain.Common;

namespace Delivery.Managment.Domain
{
    public class DeliveryRequest : BaseDomainEntity
    {
        public DateTime ShipDate { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public int DeliveryTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool? Sent {  get; set; }
        public bool Cancelled { get; set; }


    }
}
