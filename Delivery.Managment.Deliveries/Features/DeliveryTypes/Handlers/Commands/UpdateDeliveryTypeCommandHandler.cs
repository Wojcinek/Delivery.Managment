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
    public class UpdateDeliveryTypeCommandHandler : IRequestHandler<UpdateDeliveryTypeCommand, Unit>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public UpdateDeliveryTypeCommandHandler(IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateDeliveryTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateDeliveryTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.DeliveryTypeDto);

            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }

            var deliveryType = await _deliveryTypeRepository.get(request.DeliveryTypeDto.Id);

            _mapper.Map(request.DeliveryTypeDto, deliveryType);

            await _deliveryTypeRepository.Update(deliveryType);

            return Unit.Value;
        }
    }
}
