using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
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
                return Ok(new { message = "Recipe Saved Successfully", recipeId = rec.RecipeId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Recipe(int id)
        {
            try
            {
                bizRecipe r = new();
                r.Load(id);
                r.Delete(id);
                
                return Ok(new { message = $"{r.RecipeName} was deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}
