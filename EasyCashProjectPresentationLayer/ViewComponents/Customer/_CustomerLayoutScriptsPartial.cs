using Microsoft.AspNetCore.Mvc;

namespace EasyCashProjectPresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptsPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
