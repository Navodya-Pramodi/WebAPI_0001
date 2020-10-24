using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_0001.Model;

namespace WebAPI_0001.Controllers
{
    [ApiController]
    [Route("CustomerDetails")]
    public class CustomerDetailsController : ControllerBase
    {
        [HttpGet]
        [Route("CustomerDetails")]
        public ActionResult GetDetails()
        {
            CustomerDetails a = new CustomerDetails()
            {
                Id = 01,
                Old = 20,
                Name = "Navodya",
                Address = "Horana"
            };
            CustomerDetails b = new CustomerDetails()
            {
                Id = 02,
                Old = 23,
                Name = "Kaushalya",
                Address = "Gampaha"
            };

            CustomerDetails c = new CustomerDetails()
            {
                Id = 03,
                Old = 23,
                Name = "Tharu",
                Address = "Colombo"
            };
            List<CustomerDetails> e = new List<CustomerDetails>();
            e.Add(a);
            e.Add(b);
            e.Add(c);

            return Ok(e);
        }
    }
}
