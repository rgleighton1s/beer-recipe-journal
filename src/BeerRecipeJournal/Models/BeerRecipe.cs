using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerRecipeJournal.Models
{
    public class BeerRecipe
    {
        public int Id { get; set; }
        public string BeerName { get; set; }
        public string StyleName { get; set; }
        public int Ibu { get; set; }
        public double Og { get; set; }
        public double Fg { get; set; }
        public double Abv { get; set; }

        //public Ingredient[] Ingredients { get; set; }
    }
}