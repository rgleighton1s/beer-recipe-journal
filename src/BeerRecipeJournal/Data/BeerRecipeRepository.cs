using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeerRecipeJournal.Models;

namespace BeerRecipeJournal.Data
{
    public class BeerRecipeRepository
    {
        public BeerRecipe GetBeerRecipe()
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

            return beerRecipe;
        }

    }
}