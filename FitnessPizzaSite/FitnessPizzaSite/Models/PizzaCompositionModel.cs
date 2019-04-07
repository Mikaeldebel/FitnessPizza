using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessPizzaSite.Models
{
    public class PizzaCompositionModel
    {
        //variabler til Pizza på site
        public string Name { get; set; }
        public string Indgredients { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
