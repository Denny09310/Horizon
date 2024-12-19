using Blazorise;
using Blazorise.Icons.FontAwesome;
using Blazorise.Tailwind;
using Horizon.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorise();
builder.Services.AddTailwindProviders();
builder.Services.AddFontAwesomeIcons();

await builder.Build().RunAsync();