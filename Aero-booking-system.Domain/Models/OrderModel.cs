using Aero_booking_system.DAL.Entities;
using System;

namespace Aero_booking_system.Domain.Models
{
    public class OrderModel
    {
        public long? UserId { get; set; }
        public int PeopleCount { get; set; }
        public long? RestaurantId { get; set; }
     //   public RestaurantEntity Restaurant { get; set; }
        public DateTime VisitAt { get; set; }
    }
}
