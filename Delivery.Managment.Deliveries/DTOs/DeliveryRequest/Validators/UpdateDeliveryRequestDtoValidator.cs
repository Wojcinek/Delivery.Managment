using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators
{
    public class UpdateDeliveryRequestDtoValidator : AbstractValidator<UpdateDeliveryRequestDto>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;

        public UpdateDeliveryRequestDtoValidator(IDeliveryTypeRepository deliveryTypeRepository)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            Include(new IDeliveryRequestDtoValidator(_deliveryTypeRepository));
        }
    }
}
