namespace MultiVendorMarketplace.Models.Services.Interfaces
{
    public interface IProductService
    {
        public List<Product>? GetProducts();
        public Product? GetProductById(int id);

        public List<Product>? GetByStoreId(int storeid);
    }
}
