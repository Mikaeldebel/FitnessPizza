using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessPizzaSite.Models;
using FitnessPizzaSite.PizzaMenu;

namespace FitnessPizzaSite.Services
{
    public class PizzaMenu : IPizzaMenu
    {
        public Task<List<PizzaCompositionModel>> GetMenu()
        {
            List<PizzaCompositionModel> pizzaModel = PizzaMenuList.GetMenuList();
            return Task.FromResult(pizzaModel);
        }

        public Task<bool> GetMenuList(MenuModel menuModel)
        {
            return Task.FromResult(true);
        }
    }
}
