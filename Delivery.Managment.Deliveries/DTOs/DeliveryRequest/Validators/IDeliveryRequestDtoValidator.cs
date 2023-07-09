using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators
{
    public class IDeliveryRequestDtoValidator : AbstractValidator<IDeliveryRequestDto>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;

        public IDeliveryRequestDtoValidator(IDeliveryTypeRepository deliveryTypeRepository)
        {
            _deliveryTypeRepository = deliveryTypeRepository;

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
