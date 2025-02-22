using Microsoft.EntityFrameworkCore;
using EnterpriseCore.Infrastructure.Persistence;
using Microsoft.OpenApi.Models;
using EnterpriseCore.Application.Interfaces;
using EnterpriseCore.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add EF Core Service
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Register Generic Repository
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); // ✅ Fix Here!

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Required for Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Enterprise Core API",
        Version = "v1"
    });
});


var app = builder.Build();

// Enable Swagger for both Development & Production (optional)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Enterprise Core API v1");
        c.RoutePrefix = string.Empty; // Opens at root URL
    });
}
else
{
    // Configure Swagger for production (optional)
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Enterprise Core API v1");
        c.RoutePrefix = string.Empty; // Opens at root URL
    });
}

// Fix Middleware Order (Important for .NET 9)
app.UseRouting(); // Ensures correct routing
app.UseAuthorization();
app.MapControllers();

app.Run();
