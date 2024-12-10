using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutMainSectionViewbagComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
