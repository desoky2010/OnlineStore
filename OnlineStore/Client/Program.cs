using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineStore.Client;
using OnlineStore.Client.Services.CategoryServices;
using OnlineStore.Client.Services.ProductServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductServ, ProductServ>();
builder.Services.AddScoped<ICategoryServ, CategoryServ>();
await builder.Build().RunAsync();
