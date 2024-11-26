using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListPaginationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
