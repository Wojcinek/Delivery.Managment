using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryAllocation.Validators;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators;
using Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Handlers.Commands
{
    public class CreateDeliveryAllocationCommandHandler : IRequestHandler<CreateDeliveryAllocationCommand, int>
    {
        private readonly IDeliveryAllocationRepository _deliveryAllocationRepository;
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public CreateDeliveryAllocationCommandHandler(IDeliveryAllocationRepository deliveryAllocationRepository, IDeliveryTypeRepository deliveryTypeRepository , IMapper mapper)
        {
            _deliveryAllocationRepository = deliveryAllocationRepository;
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateDeliveryAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateDeliveryAllocationDtoValidator(_deliveryTypeRepository);
            var validationResult = await validator.ValidateAsync(request.DeliveryAllocationDto);

            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }

            var deliveryAllocation = _mapper.Map<DeliveryAllocation>(request.DeliveryAllocationDto);

            deliveryAllocation = await _deliveryAllocationRepository.Add(deliveryAllocation);

            return deliveryAllocation.Id;
        }
    }
}
