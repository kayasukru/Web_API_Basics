using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("API/Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        // Dependence Injection
        // readonly olarak tanımlanan bir değişkene
        // 1- Tanımlandığı yerde
        // 2- Constructor Metodda 
        // atama yapılabilir. Başka hiçbir yerde atama yapılamaz.
        // Bu işleme Dependence Injection denir.
        private readonly ILogger<ProductsController> _logger;

        // _logger değişkenine değer atanıyor
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = new List<Product>()
            {
                new Product(){Id=1, ProductName="Computer"},
                new Product(){Id=2, ProductName="Keyboard"},
                new Product(){Id=3, ProductName="Mouse"}
            };

            // log kaydı ekrana yazıldı.
            // Terminal ekranı ve Output -> Debug pencesinde görülür
            // istenirse herhangi bir yere de kayıt yaoılabilir.
            _logger.LogInformation("GetAllProducts metodu çalıştı.");  

            return Ok(products);
        }

        [HttpPost]
        public IActionResult GetAllProducts([FromBody] Product product)
        {
            // log kaydı ekrana yazıldı.
            // Terminal ekranı ve Output -> Debug pencesinde görülür
            // istenirse herhangi bir yere de kayıt yaoılabilir.
            _logger.LogWarning("Product oluştu.");

            return StatusCode(201); //Creat işlemi oldu
        }


    }
}
