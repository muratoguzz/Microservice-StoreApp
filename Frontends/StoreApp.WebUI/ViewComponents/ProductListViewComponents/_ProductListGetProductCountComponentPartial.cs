using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListGetProductCountComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
