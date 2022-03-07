namespace backend.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }
        public MeasureUnit MeasureUnit { get; set; }
        public int MeasureQuantity { get; set; }

        public double Price { get; set; }

        public double LowestMeasureUnitPrice { get; set; }
    }
}
