using Microsoft.AspNetCore.Mvc;

namespace EasyCashProjectPresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutContentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
