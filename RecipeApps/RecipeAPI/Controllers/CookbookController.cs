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
        public List<bizCookbookSummary> Get()
        {
            return new bizCookbookSummary().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public bizCookbookSummary GetCookbook(int id)
        {
            bizCookbookSummary book = new();
            book.Load(id);
            return book;
        }
    }
}
