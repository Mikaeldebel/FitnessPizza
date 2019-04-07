using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessPizzaSite.Services;

namespace FitnessPizzaSite.Controllers
{
    public class ViewMenuController : Controller
    {
        private IPizzaMenu _pizzaMenu;

        public ViewMenuController(IPizzaMenu pizzaMenu)
        {
            _pizzaMenu = pizzaMenu;
        }

        public async Task<IActionResult> Index()
        {
            var pizzas = await _pizzaMenu.GetMenu();
            return View(pizzas);
        }
    }
}