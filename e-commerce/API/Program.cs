using System.IO;
using API.Middlewares;
using Microsoft.EntityFrameworkCore;
using API.Data;
// using API.Entity; // Program.cs'te şart değil, istersen bırakma

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
{
    var root = builder.Environment.ContentRootPath;

    var dbPath = Path.Combine(root, "ecommerce.db");
    Console.WriteLine($"[DB PATH] {dbPath}");

    options.UseSqlite($"Data Source={dbPath}");
});

builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseMiddleware<ExceptionHandling>();
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Demo API v1");
        options.RoutePrefix = "swagger";
    });
if (app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5173");
});

app.UseAuthorization();
app.MapControllers();
app.Run();
