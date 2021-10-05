using System;

namespace AppRecipesBAL.Entities
{
    public class StepRecipe : Base
    {
        public Guid ID_Recipe { get; set; }
        public Guid ID_Step { get; set; }
    }
}
