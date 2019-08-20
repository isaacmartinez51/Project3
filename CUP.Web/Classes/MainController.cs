using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Continental.CUP.Repositories.ViewModels;

namespace Continental.CUP.Web.Classes
{
    /// <summary>
    /// Main base controller 
    /// </summary>
    public class MainController : Controller
    {
        public AppSettings AppSettings { get; set; }

        public MainController(){}

        /// <summary>
        /// Stores the logged user into a session object
        /// </summary>
        public UserVModel CurrentUser
        {
            get
            {
                UserVModel user = default(UserVModel);
                var data = this.Request?.HttpContext?.Session?.GetString("User");
                if (null != data)
                {
                    user = JsonConvert.DeserializeObject<UserVModel>(data);
                }
                return user;
            }
            set
            {
                this.Request.HttpContext.Session.SetString("User", JsonConvert.SerializeObject(value));
            }
        }
    }
}
