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
    public class DeliveryRequestRepository : GenericRepository<DeliveryRequest>, IDeliveryRequestRepository
    {
        private readonly DeliveryManagmentDbContext _dbContext;

        public DeliveryRequestRepository(DeliveryManagmentDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeSentStatus(DeliveryRequest deliveryRequest, bool? DeliveryStatus)
        {
            deliveryRequest.Sent = DeliveryStatus;
            _dbContext.Entry(deliveryRequest).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<DeliveryRequest>> GetDeliveryRequestWithDetails()
        {
            var deliveryRequests = await _dbContext.DeliveryRequests
                .Include(q => q.DeliveryType)
                .ToListAsync();
            return deliveryRequests;
        }

        public async Task<DeliveryRequest> GetDeliveryRequestWithDetails(int id)
        {
            var deliveryRequest = await _dbContext.DeliveryRequests
                .Include(q => q.DeliveryType)
                .FirstOrDefaultAsync(q => q.Id == id);

            return deliveryRequest;
        }
    }
}
