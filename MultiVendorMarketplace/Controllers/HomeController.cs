using Microsoft.AspNetCore.Mvc;
using MultiVendorMarketplace.Models;
using System.Diagnostics;

namespace MultiVendorMarketplace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult About()
        {
            return View();
        }
    }
}
