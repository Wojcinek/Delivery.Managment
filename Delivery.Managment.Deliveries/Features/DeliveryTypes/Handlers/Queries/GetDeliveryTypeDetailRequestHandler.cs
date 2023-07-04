using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryType;
using Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Queries;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryTypes.Handlers.Queries
{
    internal class GetDeliveryTypeDetailRequestHandler : IRequestHandler<GetDeliveryTypeDetailRequest, DeliveryTypeDto>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public GetDeliveryTypeDetailRequestHandler(IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }

        public async Task<DeliveryTypeDto> Handle(GetDeliveryTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var deliveryTypes = await _deliveryTypeRepository.get(request.Id);
            return _mapper.Map<DeliveryTypeDto>(deliveryTypes);
        }
    }
}
