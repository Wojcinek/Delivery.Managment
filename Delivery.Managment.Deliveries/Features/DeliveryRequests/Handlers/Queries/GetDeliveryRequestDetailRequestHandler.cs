using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Queries;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Queries
{
    public class GetDeliveryRequestDetailRequestHandler : IRequestHandler<GetDeliveryRequestDetailRequest, DeliveryRequestDto>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public GetDeliveryRequestDetailRequestHandler(IDeliveryRequestRepository deliveryRequestRepository, IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }

        public async Task<DeliveryRequestDto> Handle(GetDeliveryRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var deliveryRequest = await _deliveryRequestRepository.GetDeliveryRequestWithDetails(request.Id);
            return _mapper.Map<DeliveryRequestDto>(deliveryRequest);
        }
    }
}
