using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_0001.Model;
using WebAPI_0001.Services;

namespace WebAPI_0001.Controllers
{
    [Route("CustomerDetails")]
    [ApiController]
    public class CustomerDetailsController : ControllerBase
    {
        [HttpGet]
        [Route("CustomerDetails")]
        public ActionResult CustomerDetails()
        {
            CustomerDetailsServices c = new CustomerDetailsServices();
            var listOfCustomers = c.GetCustomerDetails();
            return Ok(listOfCustomers);
        }
    }
}
