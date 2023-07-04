﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Domain;

namespace Delivery.Managment.Deliveries.Persistence.NewFolder
{
    public interface IDeliveryRequestRepository : IGenericRepository<DeliveryRequest>
    {
        Task<DeliveryRequest> GetDeliveryRequestWithDetails(int id);

        Task<List<DeliveryRequest>> GetDeliveryRequestWithDetails();

    }
}
