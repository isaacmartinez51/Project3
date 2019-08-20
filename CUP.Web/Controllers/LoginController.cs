using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Continental.CUP.Web.Classes.Exceptios;
using Continental.CUP.Web.Classes.Extensions;
using Continental.CUP.Web.Classes;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Continental.CUP.Repositories.Data;
using System;
using Continental.CUP.Repositories.ViewModels;
using Continental.CUP.Repositories.Interfaces;

namespace Continental.CUP.Web.Controllers
{
    public class LoginController : MainController
    {
        //private ApplicationDbContext _context;
        private IUserRepository _repository;
        private IActionDetailRepository _repositoryAction;
        public LoginController(IOptions<AppSettings> appSettings,  IUserRepository repository, IActionDetailRepository repositoryAction) //ApplicationDbContext context,
        {
            _repository = repository;
            _repositoryAction = repositoryAction;
            //_context = context;
            this.AppSettings = appSettings.Value;
        }


        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public async Task<ActionResult> Index(UserVModel user)
        {
            ModelState.CleanUp("FirtsName", "LastName");
            if (ModelState.IsValid)
            {


                try
                {

                    string originalPassword = user.Password;
                    //Step 1
                    user.Password = Tools.GetHashedPassword(this.AppSettings, user.Password);
                    //Step 2
                    var userLogin = await UserLogin(user.UserName, user.Password);
                    if (null != userLogin)
                    {
                        base.CurrentUser = userLogin;

                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                catch (DataValidationException dex)
                {

                    this.ModelState.AddModelError(dex.PropertyName, dex.ErrorMessage);
                }
            }
            user.Password = string.Empty;
            return View(user);
        }

        #region LOGIN
        private async Task<UserVModel> UserLogin(string userName, string password)
        {
            var user = await Login(userName, password);

            if (null == user)
                throw new DataValidationException("UserName", string.Format("El usuario {0} no existe.", userName));

            if (user.Password != password)
                throw new DataValidationException("Password", "Contraseña invalida.");

            if (1 != user.Status)
                throw new DataValidationException("Email", string.Format("El usuario {0} no está activo.", userName));

            user.Password = string.Empty;

            UserVModel userV = JsonConvert.DeserializeObject<UserVModel>(JsonConvert.SerializeObject(user).ToString());
            return userV;
        }

        private async Task<UserVModel> Login(string userName, string password) {
            var user = _repository.GetQueryByUserName(userName);
            try
            {
                
                
                if (null != user)
                {
                    if (user.IsSuperAdmin)
                        return user;
                    else
                    {
                        user.ActionDetailList = await _repositoryAction.GetQueryActionDetailByIdUser(user.UserID);

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DataValidationException("Error", string.Format("Error de conexión a la base de datos: {0}", ex.Message));
            }
            //return null;
            return user;

        }
        #endregion



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Index(Continental.CUP.Business.ViewModel.Base.UserModel userModel)
        //{
        //    ModelState.CleanUp("FirtsName", "LastName");

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            string originalPassword = userModel.Password;
        //            userModel.Password = Tools.GetHashedPassword(this.AppSettings, userModel.Password);

        //            UserModel user = await new UserRule().Login(userModel.UserName, userModel.Password);

        //            if (null != user)
        //            {
        //                base.CurrentUser = user;

        //                return RedirectToAction("Index", "Dashboard");
        //            }
        //        }
        //        catch (DataValidationException dex)
        //        {
        //            this.ModelState.AddModelError(dex.PropertyName, dex.ErrorMessage);
        //        }
        //    }

        //    userModel.Password = string.Empty;
        //    return View(userModel);
        //}

        #region LOGOUT
        public IActionResult Logout()
        {
            base.CurrentUser = null;

            return RedirectToAction("Index", "Login");
        }
        #endregion
    }
}