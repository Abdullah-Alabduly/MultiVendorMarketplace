using MultiVendorMarketplace.Models.Repositories;
using MultiVendorMarketplace.Models.Services.Interfaces;

namespace MultiVendorMarketplace.Models.Services.Implementations
{
    public class StoreService : IStoreService
    {
        private List<Store> _stores;

        public StoreService()
        {
            _stores = DemoData.stores;
        }

        public Store? GetStoreById(int id) 
        {
            var store = _stores.FirstOrDefault(s => s.Id == id);
           if(store == null)
            {
                return null;
            }
            store.products = new ProductService().GetByStoreId(id);
            return store;
        }

        public List<Store> GetStores()=> _stores;
    }
}
