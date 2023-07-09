using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryType.Validators
{
    public class IDeliveryTypeDtoValidator : AbstractValidator<IDeliveryTypeDto>
    {
        public IDeliveryTypeDtoValidator()
        {
            RuleFor(p => p.Name)
               .NotEmpty()
               .NotNull()
               .MaximumLength(50).WithMessage("Maximum characters 50");
        }
    }
}
