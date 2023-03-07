using Core.Dtos;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRecipeService
    {
        Task<IEnumerable<RecipeDto>> GetAll();
        Task<RecipeDto?> GetById(int id);
        Task Create(RecipeDto recipe);
        Task Edit(RecipeDto recipe);
        Task Delete(int id);
    }
}
