using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessPizzaSite.PizzaMenu;

namespace FitnessPizzaSite.Models
{
    public class MenuModel
    {
        public List<PizzaCompositionModel> GetMenuList()
        {
            return PizzaMenuList.GetMenuList();
        }

    }
}
