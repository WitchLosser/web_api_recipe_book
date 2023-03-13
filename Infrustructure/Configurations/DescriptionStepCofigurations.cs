using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Core.Dtos;

namespace Infrustructure.Configurations
{
    internal class DescriptionStepCofigurations : IEntityTypeConfiguration<DescriptionStep>
    {
        public void Configure(EntityTypeBuilder<DescriptionStep> builder)
        {
            builder
            .HasKey(mg => new { mg.StepId, mg.RecipeId });
            builder
                .HasOne(ds => ds.Recipe)
                .WithMany(r => r.DescriptionSteps)
                .HasForeignKey(mg => mg.RecipeId);

        }

    }
}
