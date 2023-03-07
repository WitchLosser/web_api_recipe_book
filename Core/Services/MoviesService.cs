using AutoMapper;
using Core.Dtos;
using Core.Interfaces;
using Core.Entities;

namespace Core.Services
{
    public class RecipesService : IRecipeService
    {
        private readonly IRepository<Recipe> recipesRepo;
        private readonly IMapper mapper;

        public RecipesService(IRepository<Recipe> recipesRepo, IMapper mapper)
        {
            this.recipesRepo = recipesRepo;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<RecipeDto>> GetAll()
        {
            var result = await recipesRepo.Get();

            return mapper.Map<IEnumerable<RecipeDto>>(result);
        }

        public async Task<RecipeDto?> GetById(int id)
        {
            Recipe? item = await recipesRepo.GetByID(id);

            if (item == null) return null; // throw exception
            
            return mapper.Map<RecipeDto>(item);
        }

        public async Task Edit(RecipeDto dto)
        {
            await recipesRepo.Update(mapper.Map<Recipe>(dto));
            await recipesRepo.Save();
        }

        public async Task Create(RecipeDto dto)
        {
            await recipesRepo.Insert(mapper.Map<Recipe>(dto));
            await recipesRepo.Save();
        }

        public async Task Delete(int id)
        {
            if (await recipesRepo.GetByID(id) == null) return; // throw exception

            await recipesRepo.Delete(id);
            await recipesRepo.Save();
        }
    }
}
