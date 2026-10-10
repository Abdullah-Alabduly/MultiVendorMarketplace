using Microsoft.AspNetCore.Mvc;
using MultiVendorMarketplace.Models.Services.Interfaces;

namespace MultiVendorMarketplace.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _iproductService;
        public ProductController(IProductService iproductService)
        {
            _iproductService = iproductService;
        }

        [HttpGet("/products")]
        public IActionResult Index()
        {
            var products = _iproductService.GetProducts();
            return View(products);
        }
        [HttpGet("/products/{id:int}")]
        public IActionResult Details(int id) 
        {  
            var product = _iproductService.GetProductById(id);

            return (product == null)? NotFound("The Product Not Found") :View(product); 
        }
    }
}
