using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Delivery.Managment.Deliveries.DTOs.DeliveryType.Validators
{
    public class UpdateDeliveryTypeDtoValidator : AbstractValidator<DeliveryTypeDto>
    {
        public UpdateDeliveryTypeDtoValidator()
        {
            Include(new IDeliveryTypeDtoValidator());
        }
    }
}
