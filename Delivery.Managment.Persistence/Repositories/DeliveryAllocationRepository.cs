using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Managment.Persistence.Repositories
{
    public class DeliveryAllocationRepository : GenericRepository<DeliveryAllocation>, IDeliveryAllocationRepository
    {
        private readonly DeliveryManagmentDbContext _dbContext;

        public DeliveryAllocationRepository(DeliveryManagmentDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DeliveryAllocation>> GetAllDeliveryAllocationWithDetails()
        {
            var deliveryAllocations = await _dbContext.DeliveryAllocations
                .Include(q => q.DeliveryType)
                .ToListAsync();
            return deliveryAllocations;
        }

        public async Task<DeliveryAllocation> GetDeliveryAllocationWithDetails(int id)
        {
            var deliveryAllocation = await _dbContext.DeliveryAllocations
                .Include (q => q.DeliveryType)
                .FirstOrDefaultAsync(q => q.Id == id);

            return deliveryAllocation;
        }
    }
}
