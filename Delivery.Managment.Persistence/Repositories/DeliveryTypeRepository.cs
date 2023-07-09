using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;

namespace Delivery.Managment.Persistence.Repositories
{
    public class DeliveryTypeRepository : GenericRepository<DeliveryType>, IDeliveryTypeRepository
    {
        private readonly DeliveryManagmentDbContext _dbContext;

        public DeliveryTypeRepository(DeliveryManagmentDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
