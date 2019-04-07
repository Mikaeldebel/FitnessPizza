using FitnessPizzaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessPizzaSite.PizzaMenu
{
    public class PizzaMenuList
    {
        public static List<PizzaCompositionModel> GetMenuList()
        {
            //hardcoded pizzaliste til site. Kunne evt ændres så en admin kan tilføje nye pizza fra hjemmesiden. 
            List<PizzaCompositionModel> menuListe = new List<PizzaCompositionModel>();

            //Forsøgte at gøre disse underholdende at læse for at spice siden lidt op med dårlig humor.
            PizzaCompositionModel PizzaNumberOne = new PizzaCompositionModel
            {
                Name = "Storken",
                Indgredients = "Ost, Salsa, Storkenæb, Oregano & Gåselever",
                Description = "Har du nogensinde undret dig over hvordan en muligvis ulovlig pizza med næbet fra et fredet dyr smager? Heller ikke mig, men du kan bestille den her fordi: grundlag.",
                Price = 16000
            };

            PizzaCompositionModel PizzaNumberTwo = new PizzaCompositionModel
            {
                Name = "Pizza Myggeben",
                Indgredients = "Ost, Artiskokker, friterede Myggeben vendt i sukker",
                Description = "Denne pizza findes udelukkende fordi folk vil spise hvad som helst hvis du bilder dem ind at det er en delikasse. Yderst delikat pizza.",
                Price = 40

            };

            PizzaCompositionModel PizzaNumberThree = new PizzaCompositionModel
            {
                Name = "Margarina",
                Indgredients = "Ost, Tomatsauce, Oregano, 1 pakke smeltet margarine",
                Description = "Fitness Pizza's tag på en klassisk Margarita pizza. Serveres ubagt i en våd pizzabakke",
                Price = 35
            };

            menuListe.Add(PizzaNumberOne);
            menuListe.Add(PizzaNumberTwo);
            menuListe.Add(PizzaNumberThree);
            return menuListe;
        }

    }
}
