using System;
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
        public string? step1 { get; set; }
        public string? step2 { get; set; }
        public string? step3 { get; set; }
        public string? step4 { get; set; }
        public string? step5 { get; set; }
        public string? step6 { get; set; }
        public string? step7 { get; set; }
        public string? step8 { get; set; }
        public string? step9 { get; set; }
        public string? step10 { get; set; }
        public string? step11 { get; set; }
        public string? step12 { get; set; }
        public string? step13 { get; set; }
        public string? step14 { get; set; }
        public string? step15 { get; set; }
    }
}
