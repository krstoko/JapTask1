using backend.Core.Common;

namespace backend.Dtos.Ingredient
{
    public class GetIngredientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MeasureUnit MeasureUnit { get; set; }
        public int PurchaseMeasureQuantity { get; set; }
        public double PurchasePrice { get; set; }
        public double LowestMeasureUnitPrice { get; set; }
    }
}
