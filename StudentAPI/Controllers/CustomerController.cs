using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Service;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ERPTestService _eRPTestService;
        public CustomerController(ERPTestService eRPTestService)
        {
            _eRPTestService = eRPTestService;
        }

        [HttpGet("high-balance")]
        public async Task<ActionResult<List<CustomerDto>>> GetHighBalanceCustomer()
        {
            var customers = await _eRPTestService.GetHighBalanceCustomersAsync();
            if (customers == null)
            {
                return NotFound("No Customer Found");
            }

            return Ok(customers);
        }
    }
}
