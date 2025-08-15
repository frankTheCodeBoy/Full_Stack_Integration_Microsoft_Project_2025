using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorFrontEnd;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");
        
        // Register HttpClient for API calls (it doesn't need to be registered in the DI container), also the http uri doesn't seem to be working, so use the https uri. I hope you use regular Visual Studio or Jetbrains Rider and not VS Code, when running this project.
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7162") });
        //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5250") });
        
        await builder.Build().RunAsync();
    }
}