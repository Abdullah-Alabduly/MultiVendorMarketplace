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

        public IActionResult Index()
        {
            //return ControllerContext.MyDisplayRouteInfo(); to display this needs insatll rick.Docs package         
            var products = _iproductService.GetProducts();
            return Json(products);
            //return View(products);
        }
        public IActionResult Details(int id) 
        {  
            var product = _iproductService.GetProductById(id);

            return (product == null)? NotFound("The Product Not Found") :View(product); 
        }
    }
}
