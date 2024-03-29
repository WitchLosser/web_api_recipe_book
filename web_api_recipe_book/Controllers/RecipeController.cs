﻿using Core.Dtos;
using Core.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace web_api_recipe_book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await recipeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id) // FromQuery, FromRoute
        {
            var item = await recipeService.GetById(id);

            return Ok(item); // JSON
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RecipeDto recipe)
        {
            if (!ModelState.IsValid) return BadRequest();
            await recipeService.Create(recipe);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] RecipeDto recipe)
        {
            if (!ModelState.IsValid) return BadRequest();

            await recipeService.Edit(recipe);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await recipeService.Delete(id);

            return Ok();
        }

    }
}
