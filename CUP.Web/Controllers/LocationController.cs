using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Continental.CUP.Repositories.Interfaces;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Continental.CUP.Web.Filters;
using Continental.CUP.Web.Classes;
using Continental.CUP.Repositories.ViewModels;

namespace Continental.CUP.Web.Controllers
{
    public class LocationController : SessionController
    {
        private readonly ILocationRepository _locationRepository;
        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public IActionResult Index()
        {
            return View(_locationRepository.GetQueryLocation());
        }

        #region Create
       
         
        #endregion
    }
}
