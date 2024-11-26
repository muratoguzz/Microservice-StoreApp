using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
