using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;

namespace OnlineStore.Server.Services.CategoryServices
{
    public interface ICategoryServ
    {
        Task<ServerResponse<List<Category>>> GetAllCategory();

        Task<ServerResponse<Category>> CreateCategory(Category category);
    }
}
