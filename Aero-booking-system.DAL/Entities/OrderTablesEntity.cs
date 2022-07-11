using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aero_booking_system.DAL.Entities
{
    public class OrderTablesEntity
    {
        public long Id { get; set; }
        public long TableId { get; set; }
        public TableEntity Table { get; set; }
        public long OrderId { get; set; }
        public OrderEntity Order { get; set; }
    }
}
