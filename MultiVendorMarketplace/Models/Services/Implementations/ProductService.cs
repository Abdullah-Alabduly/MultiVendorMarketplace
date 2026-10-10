using MultiVendorMarketplace.Models.Repositories;
using MultiVendorMarketplace.Models.Services.Interfaces;

namespace MultiVendorMarketplace.Models.Services.Implementations
{
    public class ProductService : IProductService
    {
        private List<Product> _products;

        public ProductService() 
        {
            _products = DemoData.products;
                    
        }

        public List<Product>? GetByStoreId(int storeid)
        {
          return _products.Where<Product>(p => p.StoreId == storeid).ToList();          
        }

        public Product? GetProductById(int id) => _products.FirstOrDefault(product => product.Id == id);

        public List<Product> GetProducts()
        {
            return _products;
        }

        
    }
}
