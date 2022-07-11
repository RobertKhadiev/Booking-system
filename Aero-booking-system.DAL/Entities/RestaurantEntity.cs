using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aero_booking_system.DAL.Entities
{
    public class RestaurantEntity : BaseEntity
    {
        public string Name { get; set; }
        public List<TableEntity> Tables { get; set; }
        public int AvgPrice { get; set; }
        public int AvgServiceTime { get; set; }
    }
}
