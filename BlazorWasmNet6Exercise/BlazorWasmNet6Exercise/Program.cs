using BlazorWasmNet6Exercise;
using BlazorWasmNet6Exercise.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddTransient<IGuidService, GuidService>();
/*啟動後不論在Post及Guid頁面切換，或是重整頁面，都可以看到產生全新的一組GUID，這就是Transient的特性：每次切換都產生新的實體。*/
//builder.Services.AddSingleton<IGuidService, GuidService>();
/*以Blazor Server進行就算重整網頁，也都是同一組GUID，這就是Singleton的特性：程式啟動到結束都只會有一個實體。
  以Blazor WebAssembly進行，則Singleton會產生跟Blazor Server不同的情況，原因就是Blazor WebAssembly沒有伺服器，
  每次重整網頁都會將程式下載到瀏覽器，這是一個全新的HTTP請求，所以Singleton跟Scoped都是只要一重整網頁就會產生新的實體。*/
builder.Services.AddScoped<IGuidService, GuidService>();
/*切換到Post頁面再切回來，還是同一組GUID，但重整頁面時就會產生新的一組，這就是Scoped的特性：每次產生HTTP請求都會有新的實體，Component之間則不會產生新實體。*/
await builder.Build().RunAsync();

/*
    Blazor WebAssemlby跟Blazor Server的差別
    在Startup.cs的事情被Program.cs做了，
    以及_Host.cshtml跟index.html大致相等，
    以及缺少了appsettings.json檔案，
    通常會將程式跟資料庫溝通需要的連線字串放在這個檔案，
    可證Blazor WebAssemlby確實只是被動接收資料，
    而無法主動跟資料庫溝通
 */