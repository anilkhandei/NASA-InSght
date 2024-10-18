using Microsoft.EntityFrameworkCore;
using NASA_InSight.Data;
using NASA_InSight.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Allow CORS
string AllowNASAWASM = "AllowNASAWASMApp";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowNASAWASM,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:7039")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                                
                      });
});

builder.Services.AddControllers();
builder.Services.AddDbContext<NASAInSightContext>(options =>options
    .UseSqlServer(builder.Configuration.GetConnectionString("InSight")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("NASA", httpClient =>
{
    httpClient.BaseAddress = new Uri(builder.Configuration.GetSection("NASA:BaseURI").Value!);
});

builder.Services.AddScoped<IInSightAPIService, InSightAPIService>();
builder.Services.AddScoped<IAPODAPIService, APODAPIService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors(AllowNASAWASM);
app.UseAuthorization();

app.MapControllers();

app.Run();
