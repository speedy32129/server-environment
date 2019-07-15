using Microsoft.AspNetCore.Mvc;

namespace Web_Server_Environment.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {

        public HeaderViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
