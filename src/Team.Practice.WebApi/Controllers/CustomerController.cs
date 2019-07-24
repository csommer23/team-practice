using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team.Practice.Application.Interfaces;
using Team.Practice.Domain.Models;

namespace Team.Practice.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerApplication _customerApplication;

        public CustomerController(ICustomerApplication customerApplication)
        {
            _customerApplication = customerApplication;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(Customer customer)
        {
            await _customerApplication.RegisterNewCustomerAndSendMail(customer);

            return Created("created", customer);
        }
    }
}
