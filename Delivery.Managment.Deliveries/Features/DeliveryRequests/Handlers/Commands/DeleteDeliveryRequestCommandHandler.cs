using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.Exceptions;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Handlers.Commands
{
    public class DeleteDeliveryRequestCommandHandler : IRequestHandler<DeleteDeliveryRequestCommand>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IMapper _mapper;

        public DeleteDeliveryRequestCommandHandler(IDeliveryRequestRepository deliveryRequestRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteDeliveryRequestCommand request, CancellationToken cancellationToken)
        {
            var deliveryRequest = await _deliveryRequestRepository.get(request.Id);

            if (deliveryRequest == null)
            {
                throw new NotFoundException(nameof(DeliveryRequest), request.Id);
            }

            await _deliveryRequestRepository.Delete(deliveryRequest);

            return Unit.Value;
        }
    }
}
