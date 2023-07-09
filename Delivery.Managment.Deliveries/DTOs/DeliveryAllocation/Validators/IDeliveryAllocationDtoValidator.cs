using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryAllocation.Validators
{
    public class IDeliveryAllocationDtoValidator : AbstractValidator<IDeliveryAllocationDto>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;

        public IDeliveryAllocationDtoValidator(IDeliveryTypeRepository deliveryTypeRepository)
        {
            _deliveryTypeRepository = deliveryTypeRepository;

            RuleFor(p => p.Warehouse)
                .MaximumLength(50);

            RuleFor(p => p.DeliveryTypeId)
                   .GreaterThan(0)
            .MustAsync(async (id, token) =>
            {
                var deliveryTypeExists = await _deliveryTypeRepository.Exists(id);
                return !deliveryTypeExists;

            })
                   .WithMessage("{PropertyName} does not exist");


        }
    }
}
