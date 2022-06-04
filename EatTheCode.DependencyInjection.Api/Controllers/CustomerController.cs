using EatTheCode.DependencyInjection.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatTheCode.DependencyInjection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customer { get; }
        public CustomerController(ICustomerService customer)
        {
            _customer = customer;
        }

        [HttpGet]
        public ActionResult<string> GetName(int id)
        {
            string customerName = _customer.GetName(id);
            return customerName;
        }

        
    }
}
