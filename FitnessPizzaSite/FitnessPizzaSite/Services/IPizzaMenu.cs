using FitnessPizzaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessPizzaSite.Services
{
   public interface IPizzaMenu
    {
        Task<bool> GetMenuList(MenuModel menuModel);

        Task<List<PizzaCompositionModel>> GetMenu();
    }
}
