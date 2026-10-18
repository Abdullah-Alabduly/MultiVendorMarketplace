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
        public IActionResult Create(int id,Product model)
        {
            try
            {
                if (id != model.StoreId) return NotFound("The Product Not Found");
                _iproductService.AddProduct(model);
                return RedirectToAction(actionName: nameof(Details), controllerName: nameof(Store),routeValues: new {id = model.StoreId});
            }
            catch (Exception) {
                return View();
            }
            
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _iproductService.GetProductById(id);
            if (product == null) return NotFound("The Product Not Found");
            return View(product);

        }
        [HttpPost]
        public IActionResult Update(int id, Product model)
        {
            try
            {
                if (id != model.Id) return NotFound("Product Not Found");
                _iproductService.UpdateProduct(model);
                return RedirectToAction(controllerName:nameof(Store), actionName: nameof(Details), routeValues:new {id = model.StoreId});
            }
            catch (Exception) 
            {
                return NotFound("Product Not Found");
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                 var product = _iproductService.GetProductById(id);
                return View(product);
            }
            catch (Exception)
            {
                return NotFound("Product Not Found");            
            }
           
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            try
            {
                int storeId = _iproductService.DeleteProductById(id);
                return RedirectToAction(controllerName:nameof(Store), actionName:nameof(Details) , routeValues: new {id = storeId});
            }
            catch (Exception)
            {
                return NotFound("The Product Not Found");
            }
        }
    }
}
