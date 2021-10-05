using System;

namespace AppRecipesBAL.Entities
{
    public class Base
    {
        public Guid Id { get; set; }
        public bool State { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
