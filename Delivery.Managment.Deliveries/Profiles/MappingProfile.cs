using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Managment.Deliveries.DTOs;
using Delivery.Managment.Deliveries.DTOs.DeliveryRequest;
using Delivery.Managment.Domain;

namespace Delivery.Managment.Deliveries.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DeliveryRequest, DeliveryRequestDto>().ReverseMap();
            CreateMap<DeliveryRequest, DeliveryRequestListDto>().ReverseMap();
            CreateMap<DeliveryAllocation, DeliveryAllocationDto>().ReverseMap();
            CreateMap<DeliveryType, DeliveryTypeDto>().ReverseMap();
        }
    }
}
