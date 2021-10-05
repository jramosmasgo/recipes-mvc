using System;

namespace AppRecipesBAL.Entities
{
    public class Recipe : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public Guid ID_Category { get; set; }
    }
}
