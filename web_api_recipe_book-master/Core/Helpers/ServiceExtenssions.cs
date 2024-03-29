﻿using Core.Helpers;
using Core.Interfaces;
using Core.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
namespace Core.Helpers
{
    public static class ServiceExtenssions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IJwtService, JwtService>();

        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
