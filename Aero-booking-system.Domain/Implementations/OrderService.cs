using Aero_booking_system.DAL;
using Aero_booking_system.DAL.Entities;
using Aero_booking_system.Domain.Interfaces;
using Aero_booking_system.Domain.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aero_booking_system.Domain.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly BsDbContext _context;
        private readonly IMapper _mapper;

        public OrderService(BsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<RestaurantEntity> GetRestaurantsByPlaceCount(int placeCount, DateTime visitAt)
        {
            var result = new List<RestaurantEntity>();
            var restaurants = _context.Restaurants.Include(q => q.Tables).ToList();

            foreach(var rest in restaurants)
            {
                var freeTables = _context.OrderTables.Include(q => q.Order).Include(q => q.Table)
                        .Where(q => q.Table.RestaurantId == rest.Id && q.Order.VisitAt.AddHours(2) >= visitAt && q.Order.VisitAt <= visitAt)
                        .Select(q => q.Table);
                var freePlaces = freeTables.Sum(x => x.Capacity);

                if (placeCount > freePlaces)
                {
                    continue;
                }

                result.Add(rest);
            }
            return result;
        }

        public async Task<long> CreateOrder(OrderModel orderModel)
        {
            var order = _mapper.Map<OrderEntity>(orderModel);
            var result = await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            //      var orderTables = await _context.OrderTables.AddAsync(new OrderTablesEntity { OrderId = result.Entity.Id, TableId = });
            return result.Entity.Id;
        }
    }
}
