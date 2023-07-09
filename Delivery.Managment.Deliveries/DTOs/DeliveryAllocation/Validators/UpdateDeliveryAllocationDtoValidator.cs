using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryAllocation.Validators
{
    public class UpdateDeliveryAllocationDtoValidator : AbstractValidator<UpdateDeliveryAllocationDto>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;

        public UpdateDeliveryAllocationDtoValidator(IDeliveryTypeRepository deliveryTypeRepository)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            Include(new IDeliveryAllocationDtoValidator(_deliveryTypeRepository));

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
