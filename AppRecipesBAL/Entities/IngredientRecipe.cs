using System;

namespace AppRecipesBAL.Entities
{
    public class IngredientRecipe : Base
    {
        public Guid ID_Recipe { get; set; }
        public Guid ID_Ingredient { get; set; }
        public Guid ID_UnitOfMeasurement { get; set; }
        public decimal Quantity { get; set; }
    }
}
