using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators;
using Delivery.Managment.Deliveries.DTOs.DeliveryType.Validators;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using FluentValidation;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Handlers.Commands
{
    public class CreateDeliveryRequestCommandHandler : IRequestHandler<CreateDeliveryRequestCommand, int>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public CreateDeliveryRequestCommandHandler(IDeliveryRequestRepository deliveryRequestRepository, IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateDeliveryRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateDeliveryRequestDtoValidator(_deliveryTypeRepository);
            var validationResult = await validator.ValidateAsync(request.DeliveryRequestDto);

            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }

            var deliveryRequest = _mapper.Map<DeliveryRequest>(request.DeliveryRequestDto);

            deliveryRequest = await _deliveryRequestRepository.Add(deliveryRequest);

            return deliveryRequest.Id;  


        }
    }
}
