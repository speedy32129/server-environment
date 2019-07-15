using Web_Server_Environment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web_Server_Environment.ViewComponents
{
    public class MenuUserViewComponent : ViewComponent
    {

        public MenuUserViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View();
        }
    }
}
