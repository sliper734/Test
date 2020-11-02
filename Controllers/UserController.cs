using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: Controller
    {
        [HttpGet("[action]")]
        public UserModel GetUser()
        {
            var userModel = new UserModel
            {
                UserName = "[]",
                IsAuthenticated = false
            };
            if (User.Identity.IsAuthenticated)
            {
                userModel.UserName =
                    User.Identity.Name;
                userModel.IsAuthenticated =
                    User.Identity.IsAuthenticated;
            };
            return userModel;
        }
    }

    public class UserModel
    {
        public string UserName { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
