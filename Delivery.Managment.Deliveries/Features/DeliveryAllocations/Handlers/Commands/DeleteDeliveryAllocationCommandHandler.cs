using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.Exceptions;
using Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Handlers.Commands
{
    public class DeleteDeliveryAllocationCommandHandler : IRequestHandler<DeleteDeliveryAllocationCommand>
    {
        private readonly IDeliveryAllocationRepository _deliveryAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteDeliveryAllocationCommandHandler(IDeliveryAllocationRepository deliveryAllocationRepository, IMapper mapper)
        {
            _deliveryAllocationRepository = deliveryAllocationRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteDeliveryAllocationCommand request, CancellationToken cancellationToken)
        {
            var deliveryAllocation = await _deliveryAllocationRepository.get(request.Id);

            if (deliveryAllocation == null)
            {
                throw new NotFoundException(nameof(DeliveryAllocation), request.Id);
            }

            await _deliveryAllocationRepository.Delete(deliveryAllocation);

            return Unit.Value;
        }
    }
}
