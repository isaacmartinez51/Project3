using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Continental.CUP.Web.Classes.Extensions;
using Continental.CUP.Repositories.Data.Entities;
using Continental.CUP.Repositories.ViewModels;
//

namespace Continental.CUP.Web.Classes
{
    public static class HelperAction
    {
        private static IHttpContextAccessor _accessor;
        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _accessor = httpContextAccessor;
        }

        public static HttpContext HttpContext => _accessor.HttpContext;

        public static bool IsValid(string controllerName, string actionName)
        {
            UserVModel userModel = HttpContext?.Session?.Get<UserVModel>("User");

            if (null != userModel)
            {
                if (userModel.IsSuperAdmin)
                    return true;

                var existsAction = userModel.ActionDetailList?.FirstOrDefault(p => p.ContainerName == controllerName && p.ControlID == actionName);
                if (null != existsAction)
                    return true;
            }

            return false;
        }
    }
}
