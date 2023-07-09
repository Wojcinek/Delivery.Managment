using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryType.Validators;
using Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using FluentValidation;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryTypes.Handlers.Commands
{
    public class CreateDeliveryTypeCommandHandler : IRequestHandler<CreateDeliveryTypeCommand, int>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public CreateDeliveryTypeCommandHandler(IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateDeliveryTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateDeliveryTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.DeliveryTypeDto);

            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }

            var deliveryType = _mapper.Map<DeliveryType>(request.DeliveryTypeDto);

            deliveryType = await _deliveryTypeRepository.Add(deliveryType);

            return deliveryType.Id;
        }
    }
}
