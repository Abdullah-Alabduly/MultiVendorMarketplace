using Microsoft.AspNetCore.Mvc;
using MultiVendorMarketplace.Models;
using System.Diagnostics;

namespace MultiVendorMarketplace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/about")]
       public IActionResult About()
        {
            return View();
        }
    }
}
