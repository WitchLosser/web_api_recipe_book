using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configurations
{
    internal class IngredientConfigurations : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            // Set Primary Key
            builder.HasKey(x => x.Id);

            // Set Property configurations
            builder.Property(x => x.Name)
                   .HasMaxLength(300)
                   .IsRequired();

            // set many to many relation
            builder.HasMany(x => x.Recipes).WithOne(x => x.Ingredient).HasForeignKey(x => x.IngredientId);
        }
    }
}
