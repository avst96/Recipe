using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public List<bizUsers> Get()
        {
            return new bizUsers().GetList(true);
        }

    }
}
