using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookbook> Get()
        {
            return new bizCookbook().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public bizCookbook GetCookbook(int id)
        {
            bizCookbook book = new();
            book.Load(id);
            return book;
        }
    }
}
