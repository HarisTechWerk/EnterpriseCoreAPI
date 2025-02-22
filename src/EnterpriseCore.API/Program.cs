var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // ✅ Required for Swagger
builder.Services.AddSwaggerGen(); // ✅ Adds Swagger support

var app = builder.Build();

// Enable Swagger for both Development & Production (optional)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Enterprise Core API v1");
    c.RoutePrefix = string.Empty; // Opens at root URL
});

// Fix Middleware Order (Important for .NET 9)
app.UseRouting(); // ✅ Ensures correct routing
app.UseAuthorization();
app.MapControllers();

app.Run();
