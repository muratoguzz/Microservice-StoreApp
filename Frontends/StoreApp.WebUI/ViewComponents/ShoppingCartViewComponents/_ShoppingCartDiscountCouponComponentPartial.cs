using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.ViewComponents.ShoppingCartViewComponents
{
    public class _ShoppingCartDiscountCouponComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
