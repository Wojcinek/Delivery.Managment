using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators
{
    public class CreateDeliveryRequestDtoValidator : AbstractValidator<CreateDeliveryRequestDto>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;

        public CreateDeliveryRequestDtoValidator(IDeliveryTypeRepository deliveryTypeRepository) 
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            Include(new IDeliveryRequestDtoValidator(_deliveryTypeRepository));
        }
    }
}
