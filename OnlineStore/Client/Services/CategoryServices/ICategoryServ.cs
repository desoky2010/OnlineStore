using OnlineStore.Shared.Models;

namespace OnlineStore.Client.Services.CategoryServices
{
    public interface ICategoryServ
    {
        List<Category> Categories { get; set; }

        Task GetCategries();
        Task addcategory(Category category);
    }
}
