using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryAllocation.Validators
{
    public class CreateDeliveryAllocationDtoValidator : AbstractValidator<CreateDeliveryAllocationDto>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;

        public CreateDeliveryAllocationDtoValidator(IDeliveryTypeRepository deliveryTypeRepository)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            Include(new IDeliveryAllocationDtoValidator(_deliveryTypeRepository));
        }
    }
}
