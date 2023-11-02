using Microsoft.AspNetCore.Mvc;

namespace EasyCashProjectPresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
