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

        public void AddProduct(Product product)
        {
            if (product != null) { 
                if(_products.Any()) 
                    {
                        product.Id = _products.Max(p => p.Id)+1;
                    }else product.Id = 1;
                
                 _products.Add(product);
            }
        }

        public int DeleteProductById(int id)
        {
            var product = GetProductById(id);
            if(product != null)
            {
                int storid = product.StoreId;
                _products.Remove(product);   
                return storid;            
            }
            return -1;
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

        public void UpdateProduct(Product model)
        {
            var product = GetProductById(model.Id);
            if (product != null) { 
                product.Name = model.Name;
                product.Price = model.Price;
            }
        }
    }
}
