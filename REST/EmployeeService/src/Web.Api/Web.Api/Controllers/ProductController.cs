using Applicatoin.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Dto;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        [HttpGet("ByName/{Name}")]
        public IEnumerable<Product> GetByName(string name)
        {
            return _productService.GetByName(name);
        }

        [HttpGet("ByManufacturer/{Manufacturer}")]
        public IEnumerable<Product> GetByManufacturer(string manufacturer)
        {
            return _productService.GetByManufacturer(manufacturer);
        }

        [HttpGet("ByDiscription/{Discription}")]
        public IEnumerable<Product> GetByDescription(string discription)
        {
            return _productService.GetByDescription(discription);
        }

        [HttpGet("ByPrice/{Price}")]
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return _productService.GetByPrice(price);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductDto dto)
        {
            _productService.Create(dto.Name, dto.Description, dto.Manufacturer, dto.Price, dto.Ram, dto.CPU, dto.HardDrive);
            return NoContent();
        }
    }
}