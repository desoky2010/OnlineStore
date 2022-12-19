using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;

namespace OnlineStore.Server.Services.ProductServices
{
    public interface IProductServ
    {
        Task<ServerResponse<List<Product>>> GetProducts();

        Task<ServerResponse<Product>> GetProduct(int id);

        Task<ServerResponse<List<Product>>> GetProductsByCategories(string categoryurl);

        Task<ServerResponse<List<Product>>> SearchProducts(string searchText);
    }
}
