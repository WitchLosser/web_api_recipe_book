using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RecipeIngredient
    {
        // composite primary key: MovieId + GenreId
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }

        public Recipe? Recipe { get; set; }
        public Ingredient? Ingredient { get; set; }
    }
}
