using BlazorWasmNet6Exercise;
using BlazorWasmNet6Exercise.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddTransient<IGuidService, GuidService>();
/*�Ұʫᤣ�צbPost��Guid���������A�άO���㭶���A���i�H�ݨ첣�ͥ��s���@��GUID�A�o�N�OTransient���S�ʡG�C�����������ͷs������C*/
//builder.Services.AddSingleton<IGuidService, GuidService>();
/*�HBlazor Server�i��N�⭫������A�]���O�P�@��GUID�A�o�N�OSingleton���S�ʡG�{���Ұʨ쵲�����u�|���@�ӹ���C
  �HBlazor WebAssembly�i��A�hSingleton�|���͸�Blazor Server���P�����p�A��]�N�OBlazor WebAssembly�S�����A���A
  �C������������|�N�{���U�����s�����A�o�O�@�ӥ��s��HTTP�ШD�A�ҥHSingleton��Scoped���O�u�n�@��������N�|���ͷs������C*/
builder.Services.AddScoped<IGuidService, GuidService>();
/*������Post�����A���^�ӡA�٬O�P�@��GUID�A�����㭶���ɴN�|���ͷs���@�աA�o�N�OScoped���S�ʡG�C������HTTP�ШD���|���s������AComponent�����h���|���ͷs����C*/
await builder.Build().RunAsync();

/*
    Blazor WebAssemlby��Blazor Server���t�O
    �bStartup.cs���Ʊ��QProgram.cs���F�A
    �H��_Host.cshtml��index.html�j�P�۵��A
    �H�ίʤ֤Fappsettings.json�ɮסA
    �q�`�|�N�{�����Ʈw���q�ݭn���s�u�r���b�o���ɮסA
    �i��Blazor WebAssemlby�T��u�O�Q�ʱ�����ơA
    �ӵL�k�D�ʸ��Ʈw���q
 */