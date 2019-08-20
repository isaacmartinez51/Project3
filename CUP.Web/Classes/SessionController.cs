using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Continental.CUP.Web.Filters;
using Microsoft.Extensions.Options;

namespace Continental.CUP.Web.Classes
{
    /// <summary>
    /// A session-protected class with authentication and authorization protection.
    /// </summary>
    [IsAuthenticatedAttribute]
    public class SessionController : MainController
    {
        
    }
}