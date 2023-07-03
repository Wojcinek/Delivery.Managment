using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Domain.Common;

namespace Delivery.Managment.Domain
{
    internal class DeliveryAllocation : BaseDomainEntity
    {
        public DeliveryType DeliveryType { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Warehouse { get; set; }
    }
}
