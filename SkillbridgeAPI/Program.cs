using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SkillBridgeAPI.Data;
using Taku.Core;

var builder = WebApplication.CreateBuilder(args);

// Database 
builder.Services.AddDbContext<SkillBridgeDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("SBConnection"));
});

// Dependency Injection


var assembly = Assembly.GetExecutingAssembly();
// Brokers
// Brokers
var components = assembly.GetTypes().Where(b => (b.Name.EndsWith("Broker") 
                                             || b.Name.EndsWith("Query")
                                             || b.Name.EndsWith("Mapping")
                                             || b.Name.EndsWith("Command"))
                                             && b.IsClass);
foreach (var comp in components)
{
    if (typeof(IQuery).IsAssignableFrom(comp)
        || typeof(IBroker).IsAssignableFrom(comp)
        || typeof(IMapping).IsAssignableFrom(comp)
        || typeof(IRenderingCommand).IsAssignableFrom(comp))
    {
        builder.Services.AddScoped(comp.GetInterface($"I{comp.Name}")!, comp);
    }
}

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMemoryCache();
builder.Services.AddLazyCache();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var allowedOrigins = builder.Configuration["AllowedOrigins"];
if (!string.IsNullOrEmpty(allowedOrigins))
{
    var origins = allowedOrigins.Split(";");
    app.UseCors(x => x
        .WithOrigins(origins)
        .AllowAnyMethod()
        .AllowCredentials()
        .AllowAnyHeader());
}
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
