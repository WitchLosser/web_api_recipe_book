using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Infrustructure.Configurations
{
    internal class RecipeIngredienteCofigurations : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            builder
            .HasKey(mg => new { mg.IngredientId, mg.RecipeId });
            builder
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.Ingredients)
                .HasForeignKey(mg => mg.RecipeId);
            builder
                .HasOne(mg => mg.Ingredient)
                .WithMany(g => g.Recipes)
                .HasForeignKey(bc => bc.IngredientId);
        }

    }
}
