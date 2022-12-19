using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;

namespace OnlineStore.Client.Services.ProductServices
{
    public interface IProductServ
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }

       Task GetProducts(string CategoryURL = null);

        Task<ServerResponse<Product>> GetOneProduct(int id);

        Task SearchProducts(string textsearch);
    }
}
