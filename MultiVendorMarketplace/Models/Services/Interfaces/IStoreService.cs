namespace MultiVendorMarketplace.Models.Services.Interfaces
{
    public interface IStoreService
    {
        public List<Store>? GetStores();
        public Store? GetStoreById(int id);
    }
}
