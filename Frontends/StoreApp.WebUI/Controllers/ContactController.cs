using Microsoft.AspNetCore.Mvc;

namespace StoreApp.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
