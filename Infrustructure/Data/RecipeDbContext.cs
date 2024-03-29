﻿using Infrustructure.Configurations;
using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace Infrustructure.Data
{
    public class RecipeDbContext : IdentityDbContext
    {
        public RecipeDbContext() : base() { }
        public RecipeDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ----------- Set Configurations -----------
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // ----------- Data Initialisation -----------
            modelBuilder.SeedIngredients();
            modelBuilder.SeedDescriptionSteps();
            modelBuilder.SeedRecipes();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connStr = @"Server=tcp:reacts.database.windows.net,1433;Initial Catalog=recipe;Persist Security Info=False;User ID=addmin;Password={Query-13456};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connStr);
        }

        // ---------------- Data Collections ----------------
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<DescriptionStep> DescriptionSteps { get; set; }
    }
}