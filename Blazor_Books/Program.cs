using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor_Books;
using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
// start
builder.Services
    .AddBlazorise( options =>
    {
        options.Immediate = true;
    } )
    .AddBulmaProviders()
    .AddFontAwesomeIcons();
    // end
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<BookService>();


await builder.Build().RunAsync();
