/*
 Program.cs 只有少少的幾行，其中最主要的就是 WebApplication這個 6.0 新增的類別。
 將IHOST包在裡面，簡化了不少設定，所以只要設定個端點，就可以喚起API 服務了。
 */
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
