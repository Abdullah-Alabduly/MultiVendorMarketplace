namespace MultiVendorMarketplace.Models.Repositories
{
    public static class DemoData
    {
        public static List<Product> products =
        [
            new Product(){Id = 1, Name = "iPhone",StoreId = 33, Price = 3000, Description = "A Great Product"},
            new Product(){Id = 2, Name = "Watch",StoreId = 44, Price = 200, Description = "A Great Watch"},
            new Product(){Id = 3, Name = "Smart Glass",StoreId = 33, Price = 100, Description = "A Great Glass"},
            new Product(){Id = 4, Name = "Swar",StoreId = 33, Price = 200, Description = "A Great Swar"},
            new Product(){Id = 5, Name = "Gun ",StoreId = 44, Price = 100, Description = "A Great Gun"}

        ];

        public static List<Store> stores = new()
            {
                new Store(){Id = 22, Name="Tech Store", Description = "Store for selling anythings of Devices"},
                new Store(){Id = 33, Name="Home Store", Description = "Store for selling Home tools"},
                new Store(){Id = 44, Name="Grosory Store", Description = "Store for selling foods"}

            };
    }
}
