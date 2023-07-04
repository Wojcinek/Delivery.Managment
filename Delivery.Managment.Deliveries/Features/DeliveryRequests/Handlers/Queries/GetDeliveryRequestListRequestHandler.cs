using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest;
using Delivery.Managment.Deliveries.Features.DeliveryRequests.Requests.Queries;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryRequests.Queries
{
    public class GetDeliveryRequestListRequestHandler : IRequestHandler<GetDeliveryRequestListRequest, List<DeliveryRequestListDto>>
    {
        private readonly IDeliveryRequestRepository _deliveryRequestRepository;
        private readonly IMapper _mapper;

        public GetDeliveryRequestListRequestHandler(IDeliveryRequestRepository deliveryRequestRepository, IMapper mapper)
        {
            _deliveryRequestRepository = deliveryRequestRepository;
            _mapper = mapper;
        }

        public async Task<List<DeliveryRequestListDto>> Handle(GetDeliveryRequestListRequest request, CancellationToken cancellationToken)
        {
            var deliveryRequest = await _deliveryRequestRepository.GetDeliveryRequestWithDetails();
            return _mapper.Map<List<DeliveryRequestListDto>>(deliveryRequest);
        }
    }
}
