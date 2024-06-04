using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace CuisineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisineController : ControllerBase
    {
        [HttpGet]
        public List<bizCuisine> Get()
        {
            return new bizCuisine().GetList();
        }
               
    }
}