using EDA_Inventory_API.Context;
using EDA_Inventory_API.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EDA_Inventory_API.Controllers
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly InventoryDBContext _inventoryDBContext;
        public ProductController(InventoryDBContext inventoryDBContext) {
            _inventoryDBContext = inventoryDBContext;
        }


        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> Get()
        {
            List<ProductDto> productDtos = await _inventoryDBContext.Product.Select(x => new ProductDto() {
                Id = x.Id,
                Name = x.Name,
                ProductId = x.ProductId,
                Quantity = x.Quantity
            }).ToListAsync();

            return Ok(productDtos);
        }
    }
}
