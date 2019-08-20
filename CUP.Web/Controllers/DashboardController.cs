using Microsoft.AspNetCore.Mvc;
using Continental.CUP.Web.Classes;
using Continental.CUP.Web.Filters;

namespace Continental.CUP.Web.Controllers
{
    public class DashboardController : SessionController
    {
        public IActionResult Index()
        {
            return View(base.CurrentUser);
        }

        public IActionResult LogOut()
        {
            base.CurrentUser = null;

            return RedirectToAction("Index", "Login");
        }
    }
}