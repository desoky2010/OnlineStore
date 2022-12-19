using Microsoft.AspNetCore.Components;
using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;
using System.Net.Http.Json;

namespace OnlineStore.Client.Services.CategoryServices
{
    public class CategoryServ : ICategoryServ
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public CategoryServ(HttpClient http , NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Category> Categories { get; set; }

        public async Task addcategory(Category category)
        {
            var result = await _http.PostAsJsonAsync("api/category", category);

            var response = await result.Content.ReadFromJsonAsync<List<Category>>();
            Categories = response;
            _navigationManager.NavigateTo("index");
        }

        public async Task GetCategries()
        {
            var response = await _http.GetFromJsonAsync<ServerResponse<List<Category>>>("api/category");

            Categories = response.Data;
        }
    }
}
