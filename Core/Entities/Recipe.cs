﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinToCook { get; set; }
        public ICollection<RecipeIngredient>? Ingredients { get; set; }
        public ICollection<DescriptionStep>? DescriptionSteps { get; set; }

       
    }
}
