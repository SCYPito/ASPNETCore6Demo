using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var envName = builder.Environment.EnvironmentName;
// Add services to the container.

builder.Services.AddLogging(options => 
{
    options.AddDebug();
});

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My WebAPI",
        Description = "Demo WebAPI"
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
   // options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

//builder.Services.AddScoped<IMyService, MyService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
