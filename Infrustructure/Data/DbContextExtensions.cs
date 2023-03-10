using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure
{
    public static class DbContextExtensions
    {
        public static void SeedIngredients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(new[]
            {
                new Ingredient() { Id = 1, Name = "Egg" },
                new Ingredient() { Id = 2, Name = "beef" },
                new Ingredient() { Id = 3, Name = "Fish" },
                new Ingredient() { Id = 4, Name = "Tomato" },
                new Ingredient() { Id = 5, Name = "Cheese" },
                new Ingredient() { Id = 6, Name = "Oil" },
                new Ingredient() { Id = 7, Name = "Sugar" },
                new Ingredient() { Id = 8, Name = "Ketchup" },
                new Ingredient() { Id = 9, Name = "Spageti" },
                new Ingredient() { Id = 10, Name = "Dought" },
                new Ingredient() { Id = 11, Name = "Sour cream" }
            });
        }
        public static void SeedRecipes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(new[]
            {
                new Recipe() { Id = 1, Name = "Carbonara", MinToCook = 40 },
                new Recipe() { Id = 2, Name = "Omlete", MinToCook = 15 },
                new Recipe() { Id = 3, Name = "Roast beef", MinToCook =45 },
                new Recipe() { Id = 4, Name = "Baked fish", MinToCook =60 }
            });

            modelBuilder.Entity<RecipeIngredient>().HasData(new[]
            {
                new RecipeIngredient() { RecipeId = 1, IngredientId = 1 },
                new RecipeIngredient() { RecipeId = 1, IngredientId = 2 },
                new RecipeIngredient() { RecipeId = 1, IngredientId = 5 },
                new RecipeIngredient() { RecipeId = 1, IngredientId = 9 },

                new RecipeIngredient() { RecipeId = 2, IngredientId = 1 },
                new RecipeIngredient() { RecipeId = 2, IngredientId = 6 },
                new RecipeIngredient() { RecipeId = 2, IngredientId = 8 },

                new RecipeIngredient() { RecipeId = 3, IngredientId = 2 },
                new RecipeIngredient() { RecipeId = 3, IngredientId = 6 },
                new RecipeIngredient() { RecipeId = 3, IngredientId = 8 },
                new RecipeIngredient() { RecipeId = 3, IngredientId = 11 },

                new RecipeIngredient() { RecipeId = 4, IngredientId = 3 },
                new RecipeIngredient() { RecipeId = 4, IngredientId = 4 },
                new RecipeIngredient() { RecipeId = 4, IngredientId = 6 }
            });
        }
    }
}