using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Core.DomainObjects;
using AttendanceManagementSystem.Core.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        readonly SignInManager<Teacher> signInManager;
        readonly UserManager<Teacher> userManager;
        public AccountController(SignInManager<Teacher> signInManager, UserManager<Teacher> userManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(LoginViewModel model, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            var user = userManager.FindByEmailAsync(model.Email);
            if (user is null)
                return NotFound();
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
                return LocalRedirect(returnUrl);
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

       
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}