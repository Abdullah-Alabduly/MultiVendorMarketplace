using MultiVendorMarketplace.Models.Services.Interfaces;

namespace MultiVendorMarketplace.Models.Services.Implementations
{
    public class ProductService : IProductService
    {
        private List<Product> products;

        public ProductService() 
        {
            products = new()
            {
                new Product(){Id = 1, Name = "iPhone", Price = 3000, Description = "A Great Product"},
                new Product(){Id = 2, Name = "Watch", Price = 200, Description = "A Great Watch"},
                new Product(){Id = 3, Name = "Smart Glass", Price = 100, Description = "A Great Glass"}
            };
                    
        }
        public Product? GetProductById(int id) => products.Find(product => product.Id == id);

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
