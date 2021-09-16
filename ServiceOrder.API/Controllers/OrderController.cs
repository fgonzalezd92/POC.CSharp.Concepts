using Microsoft.AspNetCore.Mvc;
using POC.Core.Entities;
using POC.Core.Interfaces.BP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceOrder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderBP _orderBP;
        public OrderController(IOrderBP orderBP)
        {
            _orderBP = orderBP;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            var result = await _orderBP.Insert(order);

            if (result)
                return Created(Url.Action("Create"), order);
            else
                return BadRequest();
        }
    }
}
