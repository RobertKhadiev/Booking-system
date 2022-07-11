using Aero_booking_system.DAL.Entities;
using Aero_booking_system.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aero_booking_system.Domain.Interfaces
{
    public interface IOrderService
    {
        public List<RestaurantEntity> GetRestaurantsByPlaceCount(int placeCount, DateTime visitAt);
        public Task<long> CreateOrder(OrderModel orderModel);
    }
}
