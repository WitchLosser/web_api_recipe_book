using Ardalis.Specification;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Core.Specifications
{
    public static class Recipes
    {
        public class OrderedAll : Specification<Recipe>
        {
            public OrderedAll()
            {
                Query
                    .OrderByDescending(x => x.Name);
            }
        }
        public class ByIds : Specification<Recipe>
        {
            public ByIds(int[] ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id));
            }
        }
        public class ById : Specification<Recipe>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.DescriptionSteps)
                    .Include(x => x.Ingredients)
                    .ThenInclude(x => x.Ingredient);
            }
        }
    }
}
