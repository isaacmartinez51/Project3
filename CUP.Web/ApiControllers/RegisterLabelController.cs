using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Continental.CUP.Web.Models;
using Newtonsoft.Json;
using System.Net;
using Continental.CUP.Web.Classes;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;

namespace Continental.CUP.Web.ApiControllers
{
    //[Authorize]
    //[Produces("application/json")]
    //[Route("api/[controller]")]
    //public class RegisterLabelController : Controller
    //{
    //    //protected LabelRule Rule { get; private set; }

    //    public AppSettings AppSettings { get; set; }

    //    public IConfiguration Configuration { get; }

    //    public RegisterLabelController(IOptions<AppSettings> appSettings, IConfiguration configuration)
    //    {
    //        this.AppSettings = appSettings.Value;

    //        //this.Rule = new LabelRule();

    //        this.Configuration = configuration;
    //    }


    //    // GET: api/RegisterLabel/Test
    //    [HttpGet("Test")]
    //    public IActionResult Test()
    //    {
    //        var userName = User.Identity.Name;

    //        return Ok($"Super secret content, I hope you've got clearance for this {userName}... {DateTime.Now}");
    //    }


    //    // GET: api/RegisterLabel/5
    //    [HttpGet("{id}", Name = "Get")]
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }


    //    /*
    //        {
	   //         UserName: "admin",
	   //         Password: "123"
    //        }         
    //    */
    //    //[HttpPost]
    //    //[AllowAnonymous]
    //    //[Route("Login")]
    //    //public async Task<IActionResult> Login([FromBody]UserLoginEModel model)
    //    //{
    //    //    if (!ModelState.IsValid)
    //    //    {
    //    //        return BadRequest(ModelState);
    //    //    }

    //    //    #region Try
    //    //    //try
    //    //    //{
    //    //    //    //var user = await new UserRule().SecuredLogin(model.UserName, model.Password);

    //    //    //    if (null != user)
    //    //    //    {
    //    //    //        var claims = new[]
    //    //    //         {
    //    //    //                new Claim(ClaimTypes.Name, user.UserName),
    //    //    //            };

    //    //    //        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["SecurityKey"]));
    //    //    //        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

    //    //    //        var token = new JwtSecurityToken(
    //    //    //            issuer: "yourdomain.com",
    //    //    //            audience: "yourdomain.com",
    //    //    //            claims: claims,
    //    //    //            expires: DateTime.Now.AddMinutes(30),
    //    //    //            signingCredentials: creds);

    //    //    //        return Ok(new
    //    //    //        {
    //    //    //            User = user,
    //    //    //            Token = new JwtSecurityTokenHandler().WriteToken(token)
    //    //    //        });
    //    //    //    }
    //    //    //    else
    //    //    //    {
    //    //    //        return BadRequest(ModelState);
    //    //    //    }
    //    //    //}
    //    //    //catch (Exception dex)//DataValidationException dex
    //    //    //{
    //    //    //    //this.ModelState.AddModelError(dex.PropertyName, dex.ErrorMessage);
    //    //    //} 
    //    //    #endregion

    //    //    return null;
    //    //}

    //    [HttpGet]
    //    [Route("CheckConfig")]
    //    public IActionResult CheckConfig()
    //    {
    //        return Ok();
    //    }

    //    // POST: api/RegisterLabel/SendLabel
    //    //[HttpPost]
    //    //[Route("SendLabel")]
    //    //[ProducesResponseType(typeof(LabelModel), 201)]
    //    //[ProducesResponseType(400)]
    //    //public async Task<IActionResult> SendLabel([FromBody]LabelModel model)
    //    //{
    //    //    if (!ModelState.IsValid)
    //    //    {
    //    //        return BadRequest(ModelState);
    //    //    }

    //    //    var data = await this.Rule.CreateMasterLabel(model);

    //    //    return Ok(data);
    //    //}

    //    // POST: api/RegisterLabel/SendLabel
    //    //[HttpGet]
    //    //[Route("GetByUniqueID/{id:guid}")]
    //    //[ProducesResponseType(typeof(LabelModel), 201)]
    //    //[ProducesResponseType(400)]
    //    //public async Task<IActionResult> GetByUniqueID(Guid id)
    //    //{
    //    //    if (!ModelState.IsValid)
    //    //    {
    //    //        return BadRequest(ModelState);
    //    //    }

    //    //    var data = await this.Rule.GetByUniqueID(id, new string[] { "LabelStatus" });

    //    //    return Ok(data);
    //    //}
    //}
}
