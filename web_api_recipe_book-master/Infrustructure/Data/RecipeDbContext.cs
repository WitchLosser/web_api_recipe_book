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
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RECIPE_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            optionsBuilder.UseSqlServer(connStr);
        }

        // ---------------- Data Collections ----------------
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<DescriptionStep> DescriptionSteps { get; set; }
    }
}