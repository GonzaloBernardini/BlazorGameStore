using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorGameStore.Server.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using shared;

namespace BlazorGameStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class LoginController : ControllerBase
    {
        private readonly TokenHelper tokenHelper;
        public LoginController(TokenHelper tokenHelper)
        {
            this.tokenHelper = tokenHelper;
        }

        //Aceptar a cualquier usuario no logeado
        [AllowAnonymous]
        [HttpPost]
        public ActionResult<string> LoginUser([FromBody]UserLogin user)
        {
            if(user.User == "user" && user.Password == "user")
            {
                return  tokenHelper.GenerateToken();
            }
            return Unauthorized();
        }

    }
}