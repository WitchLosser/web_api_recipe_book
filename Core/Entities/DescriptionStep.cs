using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DescriptionStep
    {
        public int StepId{ get; set; }
        public int RecipeId{ get; set; }
        public string Description{ get; set; }
        public Recipe? Recipe { get; set; }

    }
}
