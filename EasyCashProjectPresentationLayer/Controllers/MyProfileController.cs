using Microsoft.AspNetCore.Mvc;

namespace EasyCashProjectPresentationLayer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
