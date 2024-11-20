namespace StoreApp.Basket.Dtos
{
    public class BasketItemDto
    {
        public string ProductId { get; set; } //CatalogDb den gelicek veri
        public string ProductName { get; set; } //CatalogDb
        //public string ProductImageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
