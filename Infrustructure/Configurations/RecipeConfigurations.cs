using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Core.Configurations
{
    internal class RecipeConfigurations : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            // Set Primary Key
            builder.HasKey(x => x.Id);

            // Set Property configurations
            builder.Property(x => x.Name)
                   .HasMaxLength(200)
                   .IsRequired();

            // set many to many relation
            builder.HasMany(x => x.Ingredients).WithOne(x => x.Recipe).HasForeignKey(x => x.RecipeId);
        }
    }
}
