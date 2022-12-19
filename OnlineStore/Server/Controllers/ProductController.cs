using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Server.Data;
using OnlineStore.Server.Services.ProductServices;
using OnlineStore.Shared.Genric;
using OnlineStore.Shared.Models;

namespace OnlineStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServ _productServ;

        public ProductController(IProductServ productServ)
        {
            _productServ = productServ;
        }
        
        [HttpGet]
        public async Task<ActionResult<ServerResponse<List<Product>>>> GetAllProduct()
        {
            var response = await _productServ.GetProducts();
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ServerResponse<Product>>> GetSingleProduct(int id)
        {
            var result = await _productServ.GetProduct(id);
            return Ok(result);
        }
        [HttpGet("category/{CategoryUrl}")]
        public async Task<ActionResult<ServerResponse<List<Product>>>> GetProcByCate(string CategoryUrl)
        {
            var result = await _productServ.GetProductsByCategories(CategoryUrl);
            return Ok(result);
        }
        [HttpGet("search/{textsearch}")]
        public async Task<ActionResult<ServerResponse<List<Product>>>> GetProcBySearch(string textsearch)
        {
            var result = await _productServ.SearchProducts(textsearch);
            return Ok(result);
        }
    }
}
