using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Continental.CUP.Web.Models;

namespace Continental.CUP.Web.Controllers
{
    public class WebReaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DemoModel model)
        {
            return View("Saved", model);
        }


        public IActionResult Saved(DemoModel model)
        {
            return View(model);
        }
    }
}