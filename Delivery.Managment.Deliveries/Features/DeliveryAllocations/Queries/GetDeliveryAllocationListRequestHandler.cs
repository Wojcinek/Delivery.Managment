using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs;
using Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Queries;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Queries
{
    public class GetDeliveryAllocationListRequestHandler : IRequestHandler<GetDeliveryAllocationListRequest, List<DeliveryAllocationDto>>
    {
        private readonly IDeliveryAllocationRepository _deliveryAllocationRepository;
        private readonly IMapper _mapper;

        public GetDeliveryAllocationListRequestHandler(IDeliveryAllocationRepository deliveryAllocationRepository, IMapper mapper)
        {
            _deliveryAllocationRepository = deliveryAllocationRepository;
            _mapper = mapper;
        }
        public async Task<List<DeliveryAllocationDto>> Handle(GetDeliveryAllocationListRequest request, CancellationToken cancellationToken)
        {
            var deliveryAllocation = await _deliveryAllocationRepository.GetAll();
            return _mapper.Map<List<DeliveryAllocationDto>>(deliveryAllocation);
        }
    }
}
