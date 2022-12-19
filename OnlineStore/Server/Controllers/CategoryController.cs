using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Server.Services.CategoryServices;
using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;

namespace OnlineStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServ _categoryServ;

        public CategoryController(ICategoryServ categoryServ)
        {
            _categoryServ = categoryServ;
        }


        [HttpGet]
        public async Task<ActionResult<ServerResponse<List<Category>>>> GetAllCategories()
        {
            var category = await _categoryServ.GetAllCategory();
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<ServerResponse<Category>>> AddCategory(Category category)
        {
            var newcategory = await _categoryServ.CreateCategory(category);
            return Ok(newcategory);
        }
    }
}
