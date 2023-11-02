using Microsoft.AspNetCore.Mvc;

namespace EasyCashProjectPresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
