using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Commands;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using Delivery.Managment.Domain;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryTypes.Handlers.Commands
{
    public class DeleteDeliveryTypeCommandHandler : IRequestHandler<DeleteDeliveryTypeCommand>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public DeleteDeliveryTypeCommandHandler(IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteDeliveryTypeCommand request, CancellationToken cancellationToken)
        {
            var deliveryType = await _deliveryTypeRepository.get(request.Id);

            await _deliveryTypeRepository.Delete(deliveryType);

            return Unit.Value;
        }
    }
}
