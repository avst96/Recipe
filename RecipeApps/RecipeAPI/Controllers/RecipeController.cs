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
        [HttpGet("bycuisine{id:int:min(0)}")]
        public List<bizRecipeSummary> GetRecipebyCuisineId(int id)
        {
            bizRecipeSummary recipe = new();
            return recipe.GetRecipebyCuisineId(id);
        }

        [HttpPost]
        public IActionResult Recipe([FromForm] bizRecipe rec)
        {
            try
                {
                rec.Save();
                return Ok(new {message= "Recipe Saved Successfully", recipeId=rec.RecipeId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

    }
}
