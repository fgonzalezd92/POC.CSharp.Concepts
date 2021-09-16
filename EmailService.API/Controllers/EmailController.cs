using Microsoft.AspNetCore.Mvc;
using POC.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        [HttpPost]
        [Route("Send")]
        public IActionResult Send(EmailData email)
        {
            if (email is null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            return Ok(true);
        }
    }
}
