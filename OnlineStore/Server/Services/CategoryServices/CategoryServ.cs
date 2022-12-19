using Microsoft.EntityFrameworkCore;
using OnlineStore.Server.Data;
using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;

namespace OnlineStore.Server.Services.CategoryServices
{
    public class CategoryServ : ICategoryServ
    {
        private readonly ApplicationContext _context;

        public CategoryServ(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<ServerResponse<Category>> CreateCategory(Category category)
        {

            var cate = await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            var response = new ServerResponse<Category>
            {
                
                Success = true,
                Message="Category has been added successfully"
            };
            return response;
        }

        public async Task<ServerResponse<List<Category>>> GetAllCategory()
        {
            var category = await _context.Categories.ToListAsync();
            var response = new ServerResponse<List<Category>>
            {
                Data = category
            };
            return response;
        }
    }
}
