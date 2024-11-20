using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
