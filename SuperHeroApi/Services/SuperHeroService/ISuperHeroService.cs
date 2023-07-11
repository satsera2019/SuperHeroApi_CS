using Microsoft.AspNetCore.Mvc;
using SuperHeroApi.Models;

namespace SuperHeroApi.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetSuperHeroes();
        Task<SuperHero?> GetSingleHero(int id);
        Task<List<SuperHero>> AddHero(SuperHero hero);
        Task<List<SuperHero>?> UpdateHero(int id, SuperHero hero);
        Task<List<SuperHero>?> DeleteHero(int id);

    }
}
