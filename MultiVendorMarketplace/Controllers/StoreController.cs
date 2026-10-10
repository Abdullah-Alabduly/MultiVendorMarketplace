using Microsoft.AspNetCore.Mvc;
using MultiVendorMarketplace.Models.Services.Interfaces;

namespace MultiVendorMarketplace.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storesevice;

        public StoreController(IStoreService storeservice)
        {
            _storesevice = storeservice;
        }
        [HttpGet("/stores")]
        public IActionResult Index()
        {
            var stores = _storesevice.GetStores();
            return View(stores);
        }
        [HttpGet("/stores/{id:int}")]
        public IActionResult Details(int id)
        {
            var store = _storesevice.GetStoreById(id);

            return (store == null)? NotFound("Store Not Found") :View(store);
        }
    }
}
