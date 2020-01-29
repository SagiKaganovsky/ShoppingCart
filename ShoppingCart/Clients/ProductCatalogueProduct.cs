namespace ShoppingCart.Clients
{
    using ShoppingCart;

    public partial class ProductCatalogueClient
    {
        private class ProductCatalogueProduct
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public Money Price { get; set; }
        }
    }
}