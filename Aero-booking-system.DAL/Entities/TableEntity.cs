using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aero_booking_system.DAL.Entities
{
    public class TableEntity : BaseEntity
    {
        public long? RestaurantId { get; set; }
        public RestaurantEntity Restaurant { get; set; }
        public int Capacity { get; set; }
    }
}
