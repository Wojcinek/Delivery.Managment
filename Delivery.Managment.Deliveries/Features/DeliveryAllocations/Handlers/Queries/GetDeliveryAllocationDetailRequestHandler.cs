﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs.DeliveryAllocation;
using Delivery.Managment.Deliveries.Features.DeliveryAllocations.Requests.Queries;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using MediatR;

namespace Delivery.Managment.Deliveries.Features.DeliveryAllocations.Queries
{
    public class GetDeliveryAllocationDetailRequestHandler : IRequestHandler<GetDeliveryAllocationDetailRequest, DeliveryAllocationDto>
    {
        private readonly IDeliveryAllocationRepository _deliveryAllocationRepository;
        private readonly IMapper _mapper;

        public GetDeliveryAllocationDetailRequestHandler(IDeliveryAllocationRepository deliveryAllocationRepository, IMapper mapper)
        {
            _deliveryAllocationRepository = deliveryAllocationRepository;
            _mapper = mapper;
        }

        public async Task<DeliveryAllocationDto> Handle(GetDeliveryAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var deliveryAllocation = await _deliveryAllocationRepository.get(request.Id);
            return _mapper.Map<DeliveryAllocationDto>(deliveryAllocation);
        }
    }
}
