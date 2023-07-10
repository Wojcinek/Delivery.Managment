using Delivery.Managment.MVC.Models;
using Delivery.Managment.MVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Managment.MVC.Contracts
{
    public interface IDeliveryTypeService
    {
        Task<List<DeliveryTypeVM>> GetDeliveryTypes();
        Task<DeliveryTypeVM> GetDeliveryTypeDetails(int id);
        Task<Response<int>> CreateDeliveryType(CreateDeliveryTypeVM deliveryType);
        Task<Response<int>> UpdateDeliveryType(int id, DeliveryTypeVM deliveryType);
        Task<Response<int>> DeleteDeliveryType(int id);

    }
}
