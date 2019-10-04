using JustInMindServer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JustInMindServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public IActionResult GetCategories()
        {
            var categories = _categoryRepository.GetAll();

            return Ok(categories);
        }
    }
}