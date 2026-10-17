using Microsoft.AspNetCore.Mvc;
using MultiVendorMarketplace.Models;
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
            //return Json(products);
            return View(products);
        }
        [HttpGet]
        public IActionResult Details(int id) 
        {  
            var product = _iproductService.GetProductById(id);

            return (product == null)? NotFound("The Product Not Found") :View(product); 
        }
        [HttpGet]
        public IActionResult Create(int id)
        {

            ViewData["id"] = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            try
            {
                _iproductService.AddProduct(model);
                return RedirectToAction(actionName: nameof(Details), controllerName: "Store",routeValues: new {id = model.StoreId});

            }
            catch (Exception ex) {
                return View();
            }
            
        }
    }
}
