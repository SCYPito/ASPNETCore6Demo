/*
 Program.cs �u���֤֪��X��A�䤤�̥D�n���N�O WebApplication�o�� 6.0 �s�W�����O�C
 �NIHOST�]�b�̭��A²�ƤF���ֳ]�w�A�ҥH�u�n�]�w�Ӻ��I�A�N�i�H��_API �A�ȤF�C
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
