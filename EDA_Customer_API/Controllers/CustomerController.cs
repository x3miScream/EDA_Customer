using EDA_Customer_API.Context;
using EDA_Customer_API.Data;
using EDA_Customer_API.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EDA_Customer_API.Controllers
{

    [ApiController]
    [Route("api/v1/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDBContext _dbContext;

        public CustomerController(CustomerDBContext dbContext) {
            _dbContext = dbContext;
        }



        [HttpGet]
        public async Task<ActionResult<List<CustomerDto>>> Get()
        {
            List<Customer> customers = new List<Customer>();

            customers = await _dbContext.Customer.ToListAsync();

            List<CustomerDto> customerDtos = customers.Select(x => new CustomerDto() {
                Name = x.Name,
                ItemInCart = x.ItemInCart,
                ProductId = x.ProductId
            }).ToList();

            return Ok(customerDtos);
        }



        [HttpPost]
        public async Task<IActionResult> Post(CustomerDto customerDto) {

            Customer newCustomer = new Customer()
            {
                Name = customerDto.Name,
                ProductId = customerDto.ProductId,
                ItemInCart = customerDto.ItemInCart
            };

            await _dbContext.Customer.AddAsync(newCustomer);
            await _dbContext.SaveChangesAsync();

            return Ok("");
        }
    }
}
