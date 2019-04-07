using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessPizzaSite.Models;
using FitnessPizzaSite.Services;


namespace FitnessPizzaSite.Controllers
{
    public class UserAccountController : Controller
    {
        private IUserLogin _userLogin;
        public UserAccountController(IUserLogin userLogin)
        {
            _userLogin = userLogin;
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserAccountModel userAccountModel)
        {
            await _userLogin.RegisterCurrentUser(userAccountModel);
            ViewData["result"] = $"Brugeren {userAccountModel.FirstName} {userAccountModel.LastName} er blevet oprettet, tjek venligst din email efter en bekræftelse";
            return View();
        }
                
        public IActionResult Index()
        {
            return View();
        }


    }
}