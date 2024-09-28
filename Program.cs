using Microsoft.EntityFrameworkCore;
using NASA_InSight.Data;
using NASA_InSight.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<NASAInSightContext>(options =>options
    .UseSqlServer(builder.Configuration.GetConnectionString("InSight")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("InSight", httpClient =>
{
    httpClient.BaseAddress = new Uri(builder.Configuration.GetSection("NASA:InSightWeatherAPI").Value!);
});

builder.Services.AddScoped<IInSightAPIService, InSightAPIService>();
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
