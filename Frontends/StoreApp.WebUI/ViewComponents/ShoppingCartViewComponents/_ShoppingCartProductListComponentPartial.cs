using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.ViewComponents.ShoppingCartViewComponents
{
    public class _ShoppingCartProductListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View();
        }
    }
}
