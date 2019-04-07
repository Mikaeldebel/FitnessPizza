using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessPizzaSite.Models;

namespace FitnessPizzaSite.Services
{
    public class UserLogin : IUserLogin
    {
        //Login/registrering af nuværende bruger
        public Task<bool> RegisterCurrentUser(UserAccountModel userAccountModel)
        {
            return Task.FromResult(true);
        }
    }
}
