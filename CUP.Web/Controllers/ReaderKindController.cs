using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


using Continental.CUP.Web.Classes;
using Continental.CUP.Web.Filters;
using Continental.CUP.Repositories.Data;
using Continental.CUP.Repositories.Interfaces;
using Continental.CUP.Repositories.Data.Entities;
using Continental.CUP.Repositories.ViewModels;
using Newtonsoft.Json;
using System;

namespace Continental.CUP.Web.Controllers
{
    public class ReaderKindController : SessionController
    {
        //private readonly ApplicationDbContext _context;

        private IReaderKindRepository _repository;


        public ReaderKindController(IReaderKindRepository repository)
        {
            _repository = repository;
        }
        #region Index
        public IActionResult Index()
        {
            return View(_repository.GetQueryReaderKind());
        } 
        #endregion

        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReaderKindVModel model)
        {
            try
            {
                model.AntennaNumber = model.AntennaNumber == 0 ? null : model.AntennaNumber;
                if (!ModelState.IsValid)
                    return View(model);
                ReaderKindEModel item = JsonConvert.DeserializeObject<ReaderKindEModel>(
                                        JsonConvert.SerializeObject(model).ToString());
                await _repository.CreateItemComposedKeyAsync(item);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

    }
}
