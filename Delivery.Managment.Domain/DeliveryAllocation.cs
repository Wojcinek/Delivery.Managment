using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Managment.Domain
{
    internal class DeliveryAllocation
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Warehouse { get; set; }
    }
}
