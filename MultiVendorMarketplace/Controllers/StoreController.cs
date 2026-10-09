using Microsoft.AspNetCore.Mvc;

namespace MultiVendorMarketplace.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet("/stores")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/stores/{id:int}")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
