using Microsoft.EntityFrameworkCore;
using OnlineStore.Server.Data;
using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;
using System.Linq;

namespace OnlineStore.Server.Services.ProductServices
{
    public class ProductServ : IProductServ
    {
        private readonly ApplicationContext _context;

        public ProductServ(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<ServerResponse<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            var response = new ServerResponse<Product>();
            if(product == null)
            {
                response.Success = false;
                response.Message = "Product not found :(";
            }
            else
            {
                response.Success = true;
                response.Data=product;
            }
            return response;
        }

        public async Task<ServerResponse<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServerResponse<List<Product>>
            {
                Data = products
            };
            return response; 
        }

        public async Task<ServerResponse<List<Product>>> GetProductsByCategories(string categoryurl)
        {
            var products = await _context.Products.Where(p => p.Category.URL.ToLower().Equals(categoryurl.ToLower())).ToListAsync();
            var response = new ServerResponse<List<Product>>
            {
                Data = products
            };
            return response;
        }

        public async Task<ServerResponse<List<Product>>> SearchProducts(string searchText)
        {
            var response = new ServerResponse<List<Product>>();

            var product = await _context.Products.Where(p => p.Title.ToLower().Contains(searchText.ToLower()) ||
               p.Description.ToLower().Contains(searchText.ToLower())).ToListAsync();
               
            response.Data = product;
            return response;

        }
    }
}
