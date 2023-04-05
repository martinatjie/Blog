using Blog.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text.Json;
using Blog.Web.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add a static files directory
//builder.Services.AddSingleton(new FileProviderOptions
//{
//    FileProvider = new PhysicalFileProvider(
//        Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
//    RequestPath = "/MyStaticFiles"
//});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7137") });

builder.Services.AddOidcAuthentication(options =>
{
    // Configure your authentication provider options here.
    // For more information, see https://aka.ms/blazor-standalone-auth
    builder.Configuration.Bind("Local", options.ProviderOptions);
});

builder.Services.AddOptions<JsonSerializerOptions>().Configure(options =>
{
    options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    //options.Converters.Add(new JsonStringEnumConverter());
    options.Converters.Add(new JsonDateTimeConverter());
});

// Add logging to the builder
builder.Logging.ClearProviders();
builder.Logging.AddProvider(new BrowserConsoleLoggerProvider());

await builder.Build().RunAsync();
