﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApi.Models;

namespace SuperHeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero {
                Id = 1,
                FirstName = "Spider Man",
                LastName = "Peter",
                Name = "Parker",
                Place = "New York City",
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
           return Ok(superHeroes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return NotFound("Not Found.");
            return Ok(hero);
        }
    }
}