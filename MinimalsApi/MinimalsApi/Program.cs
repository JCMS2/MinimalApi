<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using MinimalsApi.Dominio.DTOs;
using MinimalsApi.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});

var app = builder.Build();

app.MapGet("/", () => "Hello world");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
=======
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",()=> "Hello world");

app.MapPost("/login", (MinimalsApi.Dominio.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha=="123456")
>>>>>>> 36056bd91f70c8c9311b29d96eae0cc3feecfaad
    {
        return Results.Ok("Login com sucesso");
    }
    else
    {
        return Results.Unauthorized();
    }
});
<<<<<<< HEAD

app.Run();
=======
 
app.Run();

>>>>>>> 36056bd91f70c8c9311b29d96eae0cc3feecfaad
