using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult _UILayout()
        {
            return View();
        }
    }
}
