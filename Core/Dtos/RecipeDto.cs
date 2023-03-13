using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinToCook { get; set; }
        public IEnumerable<IngredientDto>? Ingredients { get; set; }
        public IEnumerable<DescriptionStepDto>? DescriptionSteps { get; set; }
       

    }
}
