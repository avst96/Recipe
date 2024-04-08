using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipeSummary> Get()
        {
            return new bizRecipeSummary().GetList();
        }

        [HttpGet("{id:int:min(0)}")]
        public bizRecipeSummary GetRecipe(int id)
        {
            bizRecipeSummary recipe = new();
            recipe.Load(id);
            return recipe;
        }
        [HttpGet("{value}")]
        public List<bizRecipeSummary> GetRecipeByBook(string value)
        {
            bizRecipeSummary recipe = new();
            return recipe.SearchRecipeByCookbook(value);
        }
    }
}
