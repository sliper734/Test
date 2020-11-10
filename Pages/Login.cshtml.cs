using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private MySqlDbContext context;
        public LoginModel(MySqlDbContext _context)
        {
            context = _context;
        }

        public string ReturnUrl { get; set; }
        public async Task<IActionResult> OnGetAsync(string paramUsername, string paramPassword)
        {
            string returnUrl = Url.Content("~/");
            var person = await context.Persons.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == paramUsername && u.Password == paramPassword);
            if (person != null)
            {
                try
                {
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                }
                catch { }
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, paramUsername),
                    new Claim(ClaimTypes.Role, person.Role.RoleName),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };
                try
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity),authProperties);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
            }
            return LocalRedirect(returnUrl);
        }
    }
}

