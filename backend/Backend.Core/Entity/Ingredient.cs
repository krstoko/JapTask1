using backend.Core.Common;
using backend.Entity;
using System.Collections;
using System.Collections.Generic;

namespace backend.Models
{
    public class Ingredient : EntityBase
    {
        public MeasureUnit MeasureUnit { get; set; }
        public int PurchaseMeasureQuantity { get; set; }

        public double PurchasePrice { get; set; }

        public double LowestMeasureUnitPrice { get; set; }
        public List<RecipesIngredients> RecipesIngredients { get; set; }
    }
}
