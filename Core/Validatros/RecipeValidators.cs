using Core.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validatros
{
    public class RecipeValidators : AbstractValidator<RecipeDto>
    {
        public RecipeValidators()
        {
            RuleFor(x => x.Name)
              .NotEmpty()
              .MinimumLength(2);

            RuleFor(x => x.MinToCook)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);


        }
    }
}
