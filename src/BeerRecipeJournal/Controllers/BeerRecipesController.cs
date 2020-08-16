using BeerRecipeJournal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerRecipeJournal.Controllers
{
    public class BeerRecipesController : Controller
    {
        public ActionResult Detail()
        {
            var beerRecipe = new BeerRecipe()
            {
                BeerName = "Porter? I Hardly Know Her!",
                StyleName = "Porter",
                Ibu = 25,
                Og = 1.050,
                Fg = 1.010,
                Abv = 5.0
            };

            return View(beerRecipe);
        }
    }
}