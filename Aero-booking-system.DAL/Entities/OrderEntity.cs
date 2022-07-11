using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aero_booking_system.DAL.Entities
{
    public class OrderEntity : BaseEntity
    {
        public long? UserId { get; set; }
        public int PeopleCount { get; set; }
        public long? RestaurantId { get; set; }
        public RestaurantEntity Restaurant { get; set; }
        public DateTime VisitAt { get; set; }
    }
}
