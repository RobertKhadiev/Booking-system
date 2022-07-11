using Aero_booking_system.DAL.Entities;
using Aero_booking_system.Domain.Models;
using AutoMapper;

namespace Aero_booking_system.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();
            CreateMap<OrderEntity, OrderModel>();
            CreateMap<OrderModel, OrderEntity>();
        }
    }
}
