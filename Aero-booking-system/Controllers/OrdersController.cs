using Aero_booking_system.Domain.Interfaces;
using Aero_booking_system.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aero_booking_system.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetRestaurantsByPlaceCount(int placeCount, DateTime visitAt)
        {
         //   var id = await _orderService.GetRestaurantsByPlaceCount(placeCount, visitAt);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderModel orderModel)
        {
            var id = await _orderService.CreateOrder(orderModel);

            return Ok(id);
        }


    }
}
