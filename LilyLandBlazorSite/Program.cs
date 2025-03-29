using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using LilyLandBlazorSite;
using LilyLandBlazorSite.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<PaletteService>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
