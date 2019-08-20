using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//
//
//using Continental.CUP.Common.Arquitecture.Classes.Exceptions;
using System.Collections.Generic;
using Continental.CUP.Web.Filters;
using Continental.CUP.Web.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using Continental.CUP.Repositories.Interfaces;
using Continental.CUP.Repositories.ViewModels;
using Continental.CUP.Web.Classes.Exceptios;

namespace Continental.CUP.Web.Controllers
{
    public class UserController : SessionController
    {
        //public UserRule Rule { get; set; }
        IUserRepository _userRepository;
        IUserRoleRepository _userRoleRepository;

        public UserController(IOptions<AppSettings> appSettings, IUserRepository userRepository, IUserRoleRepository userRoleRepository)
        {
            this.AppSettings = appSettings.Value;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;

            //  this.Rule = new UserRule();
        }


        // GET: User
        public IActionResult Index()
        {
            return View(_userRepository.GetQueryAllUser());//await this.Rule.GetAll(1)
        }

        #region Details
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await GetUserRoleListById(id.Value);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
        private async Task<UserVModel> GetUserRoleListById(int userId)
        {
            UserVModel user = new UserVModel();
            try
            {
                if (0 != userId)
                    user = _userRepository.GetQueryByUserId(userId);

                if (null == user)
                {

                }
                else
                {
                    user.UserRoleModelList = await _userRoleRepository.GetQueryUserRoleByUserId(user.UserID);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return user;
        }
        #endregion

        #region Edit
        /// <summary>
        /// Method called for open view edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var model = await GetUserRoleListById(id.Value);

            if (model == null)
                return NotFound();

            return View(model);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UserVModel model)// UserModel model
        {
            if (id != model.UserID)
                return NotFound();


            if (ModelState.IsValid)
            {
                model.Status = 1;

                string originalPassword = string.Empty;

                if (!string.IsNullOrEmpty(model.Password))
                {
                    originalPassword = model.Password;

                    model.Password = Tools.GetHashedPassword(this.AppSettings, model.Password);
                }

                if (null != model.IDParamList && model.IDParamList.Any())
                {
                    model.UserRoleModelList = new List<UserRoleVModel>();
                    for (int index = 0; index <= model.IDParamList.Length - 1; index++)
                    {
                        int idUser = model.IDParamList[index].Split('|')[0] == "" ? model.UserID : int.Parse(model.IDParamList[index].Split('|')[0]);
                        int idRole = int.Parse(model.IDParamList[index].Split('|')[1]);
                        UserRoleVModel paramValue = new UserRoleVModel()
                        {
                            UserID = idUser,
                            RoleID = idRole,
                            Active = true
                        };
                        model.UserRoleModelList.Add(paramValue);
                    }
                }

                try
                {
                    //TODO: Metodo para insertar 
                    if (await UpdateUserRole(model))
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (DataValidationException dex)
                {
                    this.ModelState.AddModelError(dex.PropertyName, dex.ErrorMessage);
                }
                catch (Exception ex)
                {
                    model.Password = originalPassword;
                }
            }

            return View(model); // model
        }

        public async Task<bool> UpdateUserRole(UserVModel model)
        {
            return await _userRoleRepository.UpdateUserRoleTODO(model);
            //// Get current User
            //var user =  _userRepository.GetItemByExpression(x=> x.UserName == model.UserName);
            //var equal = model.Equals(user);
            ////Valida si ya existe ese UserName
            //if (_userRepository.Exist(x=> x.UserName == model.UserName && x.UserID != model.UserID))
            //{
            //    //if (userExtension.ID == user.ID)
            //    //{
            //    //    if (string.IsNullOrEmpty(userExtension.Password))
            //    //        userExtension.Password = user.Password;

            //    //    user = null;
            //    //}
            //}
            //else
            //{
            //    if (string.IsNullOrEmpty(model.Password))
            //    {
            //        throw new DataValidationException("Password", "El password no puede ser vacio.");
            //    }
            //}

            //if (null == user)
            //{
            //    return await _userRoleRepository.UpdateUserRoleTODO(model);// this.Repository.UpdateUserRole(userExtension);
            //}
            //else
            //    throw new DataValidationException("UserName", "El usuario ya existe.");
            //return false;
        }
        #endregion

        #region TODO:
        // GET: User/Create
        public async Task<IActionResult> Create()
        {
            //UserModel model = await this.Rule.GetUserRoleListByID(0);

            return View();// model
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create() // UserModel model
        //{
        //if (ModelState.IsValid)
        //{
        //    model.Status = 1;
        //    model.UserRoleModelList = new List<UserRoleModel>();

        //    if (string.IsNullOrEmpty(model.Password))
        //    {
        //        this.ModelState.AddModelError("Password", "El password no puede ser vacio.");
        //        return View(model);
        //    }

        //    string originalPassword = model.Password;

        //    model.Password = Tools.GetHashedPassword(this.AppSettings, model.Password);

        //    if (null != model.IDParamList && model.IDParamList.Any())
        //    {
        //        for (int index = 0; index <= model.IDParamList.Length - 1; index++)
        //        {
        //            UserRoleModel paramValue = new UserRoleModel()
        //            {
        //                ID = 0,
        //                UserID = 0,
        //                RoleID = int.Parse(model.IDParamList[index]),
        //                Active = true,
        //            };
        //            model.UserRoleModelList.Add(paramValue);
        //        }
        //    }

        //    try
        //    {
        //        await this.Rule.CreateUserRole(model);

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (DataValidationException dex)
        //    {
        //        this.ModelState.AddModelError(dex.PropertyName, dex.ErrorMessage);
        //    }
        //    finally
        //    {
        //        model.Password = originalPassword;
        //    }
        //}

        //    return View(); // model
        //}


        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var model = await this.Rule.GetUserRoleListByID(id.Value);

            //if (model == null)
            //{
            //    return NotFound();
            //}

            return View(); // model
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //await this.Rule.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ExistsModel(int id)
        {

            //return (null != this.Rule.GetById(id));
            return true;
        }

        //[AllowAnonymous]
        //public IActionResult Info()
        //{
        //    return View(base.CurrentUser);
        //} 
        #endregion
    }

    //public class ValidateEdit
    //{
    //    IUserRepository _userRepository;
    //    IUserRoleRepository _userRoleRepository;

    //    public ValidateEdit( IUserRepository userRepository, IUserRoleRepository userRoleRepository)
    //    {
    //        _userRepository = userRepository;
    //        _userRoleRepository = userRoleRepository;
    //    }
    //    public ValidateEdit()
    //    {

    //    }
    //    public async Task<bool> UpdateUserRole(UserVModel model)
    //    {
    //        this.
    //        // valida si existe el usuario
    //        var user = await this.Repository.GetSingle(p => p.UserName == model.UserName);

    //        if (null != user)
    //        {
    //            if (userExtension.ID == user.ID)
    //            {
    //                if (string.IsNullOrEmpty(userExtension.Password))
    //                    userExtension.Password = user.Password;

    //                user = null;
    //            }
    //        }
    //        else
    //        {
    //            if (string.IsNullOrEmpty(model.Password))
    //            {
    //                throw new DataValidationException("Password", "El password no puede ser vacio.");
    //            }
    //        }

    //        if (null == user)
    //        {
    //            return await this.Repository.UpdateUserRole(userExtension);
    //        }
    //        else
    //            throw new DataValidationException("UserName", "El usuario ya existe.");

    //    }
    //}

}
