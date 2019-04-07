using FitnessPizzaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessPizzaSite.Services
{
    //interface til brug af userlogin klasse
    public interface IUserLogin
    {
        Task<bool> RegisterCurrentUser(UserAccountModel userAccountModel);
    }
}
