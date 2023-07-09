using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryAllocation.Validators;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators;
using Delivery.Managment.Deliveries.Exceptions;
using Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Handlers.Commands
{
    public class UpdateDeliveryAllocationCommandHandler : IRequestHandler<UpdateDeliveryAllocationCommand, Unit>
    {
        private readonly IDeliveryAllocationRepository _deliveryAllocationRepository;
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public UpdateDeliveryAllocationCommandHandler(IDeliveryAllocationRepository deliveryAllocationRepository, IDeliveryTypeRepository deliveryTypeRepository ,IMapper mapper)
        {
            _deliveryAllocationRepository = deliveryAllocationRepository;
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateDeliveryAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateDeliveryAllocationDtoValidator(_deliveryTypeRepository);
            var validationResult = await validator.ValidateAsync(request.DeliveryAllocationDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var deliveryAllocation = await _deliveryAllocationRepository.get(request.DeliveryAllocationDto.Id);

            _mapper.Map(request.DeliveryAllocationDto, deliveryAllocation);

            await _deliveryAllocationRepository.Update(deliveryAllocation);

            return Unit.Value;
        }
    }
}
