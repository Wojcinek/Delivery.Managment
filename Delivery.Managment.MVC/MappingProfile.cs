using AutoMapper;
using Delivery.Managment.MVC.Models;
using Delivery.Managment.MVC.Services.Base;

namespace Delivery.Managment.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CreateDeliveryTypeDto, CreateDeliveryTypeVM>().ReverseMap();
            CreateMap<DeliveryTypeDto, DeliveryTypeVM>().ReverseMap();
        }
    }
}
