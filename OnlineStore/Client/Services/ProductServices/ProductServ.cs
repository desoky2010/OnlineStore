using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;
using System.Net.Http.Json;

namespace OnlineStore.Client.Services.ProductServices
{
    public class ProductServ : IProductServ
    {
        private readonly HttpClient _http;

        public ProductServ(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get ; set ; } = new List<Product> ();

        public event Action ProductsChanged;

        public async Task<ServerResponse<Product>> GetOneProduct(int id)
        {
            var result = await _http.GetFromJsonAsync<ServerResponse<Product>>($"api/product/{id}");
            return result;
        }

        public async Task GetProducts(string CategoryURL = null)
        {
            if (CategoryURL == null)
            {
                var result = await _http.GetFromJsonAsync<ServerResponse<List<Product>>>("api/product");
                Products = result.Data;
            }
            else
            {
                var result = await _http.GetFromJsonAsync<ServerResponse<List<Product>>>($"api/product/category/{CategoryURL}");
                Products = result.Data;
            }
            ProductsChanged.Invoke();
        }

        public async Task SearchProducts(string textsearch)
        {
            var result =await _http.GetFromJsonAsync<ServerResponse<List<Product>>>($"api/product/search/{textsearch}");
            Products = result.Data;
            ProductsChanged.Invoke();
        }
    }
}
