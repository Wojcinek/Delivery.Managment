using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Handlers.Commands
{
    public class CreateDeliveryRequestCommandHandler : IRequestHandler<CreateDeliveryRequestCommand, int>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IMapper _mapper;

        public CreateDeliveryRequestCommandHandler(IDeliveryRequestRepository deliveryRequestRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateDeliveryRequestCommand request, CancellationToken cancellationToken)
        {
            var deliveryRequest = _mapper.Map<DeliveryRequest>(request.DeliveryRequestDto);

            deliveryRequest = await _deliveryRequestRepository.Add(deliveryRequest);

            return deliveryRequest.Id;  


        }
    }
}
