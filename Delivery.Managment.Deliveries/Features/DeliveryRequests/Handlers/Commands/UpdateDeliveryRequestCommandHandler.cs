using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest.Validators;
using Delivery.Managment.Deliveries.Exceptions;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Handlers.Commands
{
    public class UpdateDeliveryRequestCommandHandler : IRequestHandler<UpdateDeliveryRequestCommand, Unit>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public UpdateDeliveryRequestCommandHandler(IDeliveryRequestRepository deliveryRequestRepository, IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {

            _deliveryRequestRepository = deliveryRequestRepository;
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDeliveryRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateDeliveryRequestDtoValidator(_deliveryTypeRepository);
            var validationResult = await validator.ValidateAsync(request.DeliveryRequestDto);
            
            if (validationResult.IsValid == false) 
            {
                throw new ValidationException(validationResult);
            }
            
            var deliveryRequest = await _deliveryRequestRepository.get(request.Id);

            if (request.DeliveryRequestDto != null)
            {
                _mapper.Map(request.DeliveryRequestDto, deliveryRequest);

                await _deliveryRequestRepository.Update(deliveryRequest);
            }
            else if(request.ChangeDeliveryRequestSentDto != null)
            {
                await _deliveryRequestRepository.ChangeSentStatus(deliveryRequest, request.ChangeDeliveryRequestSentDto.Sent);
            }


            return Unit.Value;
        }
    }
}
