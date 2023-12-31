﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Delivery.Managment.Deliveries.Persistence.NewFolder;
using AutoMapper;
using Delivery.Managment.Deliveries.Features.DeliveryTypes.Requests.Queries;
using Delivery.Managment.Deliveries.DTOs.DeliveryType;

namespace Delivery.Managment.Deliveries.Features.DeliveryTypes.Handlers.Queries
{
    public class GetDeliveryTypeListRequestHandler : IRequestHandler<GetDeliveryTypeListRequest, List<DeliveryTypeDto>>
    {
        private readonly IDeliveryTypeRepository _deliveryTypeRepository;
        private readonly IMapper _mapper;

        public GetDeliveryTypeListRequestHandler(IDeliveryTypeRepository deliveryTypeRepository, IMapper mapper)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
            _mapper = mapper;
        }



        public async Task<List<DeliveryTypeDto>> Handle(GetDeliveryTypeListRequest request, CancellationToken cancellationToken)
        {
            var deliveryTypes = await _deliveryTypeRepository.GetAll();
            return _mapper.Map<List<DeliveryTypeDto>>(deliveryTypes);
        }
    }
}
