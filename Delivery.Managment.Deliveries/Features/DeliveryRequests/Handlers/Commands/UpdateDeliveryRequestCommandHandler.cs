using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Handlers.Commands
{
    public class UpdateDeliveryRequestCommandHandler : IRequestHandler<UpdateDeliveryRequestCommand, Unit>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IMapper _mapper;

        public UpdateDeliveryRequestCommandHandler(IDeliveryRequestRepository deliveryRequestRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDeliveryRequestCommand request, CancellationToken cancellationToken)
        {
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
