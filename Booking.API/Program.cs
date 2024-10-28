using Application;
using Booking.API.Middleware;
using Infrastructure;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Host.UseSerilog((context, cfg)=> cfg.ReadFrom.Configuration(context.Configuration));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

// Global Error Handling Middleware
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
