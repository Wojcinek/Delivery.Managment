using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Domain;

namespace Delivery.Managment.Deliveries.Persistence.NewFolder
{
    public interface IDeliveryAllocationRepository : IGenericRepository<DeliveryAllocation>
    {
        Task<DeliveryAllocation> GetDeliveryAllocationWithDetails(int id);
        Task<List<DeliveryAllocation>> GetAllDeliveryAllocationWithDetails();
    }
}
