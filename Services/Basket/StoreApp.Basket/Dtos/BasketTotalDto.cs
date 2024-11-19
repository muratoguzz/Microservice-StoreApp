namespace StoreApp.Basket.Dtos
{
    public class BasketTotalDto
    {
        public string UserId { get; set; } //IdentityDb den
        public string DiscountCode { get; set; } //DiscountDb den
        public int? DiscountRate { get; set; } 
        public List<BasketItemDto> BasketItems { get; set; }
        public decimal TotalPrice { get => BasketItems.Sum(x => x.Price * x.Quantity); }
    }
}
