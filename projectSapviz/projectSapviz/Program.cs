using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using projectSapviz;
using projectSapviz.Services; // <- �j sor, hogy az AuthenticationService ismerje
using MudBlazor.Services; // <- ha MudBlazor-t haszn�lsz

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient alap�rtelmezett
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<AuthenticationService>(); // ez maradhat singleton
builder.Services.AddScoped<BacDataService>(); // <-- ez legyen scoped!
builder.Services.AddMudServices();


await builder.Build().RunAsync();


