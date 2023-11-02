using Microsoft.AspNetCore.Mvc;

namespace EasyCashProjectPresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
