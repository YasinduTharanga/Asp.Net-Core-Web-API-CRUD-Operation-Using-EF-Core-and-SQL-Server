using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Service
{
    public class ERPTestService
    {
        private readonly APIDbContext _context;
        public ERPTestService(APIDbContext context)
        {
            _context = context;
        }
        public async Task<List<CustomerDto>> GetHighBalanceCustomersAsync()
        {
            return await _context.Set<Customer>()
                .Where(c => c.Balance > 100000)
                .Select(c => new CustomerDto
                {
                    ListId = c.ListId,
                    CustName = c.CustName
                })
                .ToListAsync();

            
        }
    }

    public class CustomerDto
    {
        public int ListId { get; set; }
        public string CustName { get; set; }
    }

   
}
