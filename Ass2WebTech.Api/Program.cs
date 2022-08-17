using Ass2WebTech.Core;
using Ass2WebTech.Core.Services;
using Ass2WebTech.Data;
using Ass2WebTech.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

builder.Services.AddDbContext<BankContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("Default")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy",
   builder => builder
      .SetIsOriginAllowedToAllowWildcardSubdomains()
      .WithOrigins("*")
      .AllowAnyMethod()
      .AllowAnyHeader()
      .Build()
   );
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUserService, UserService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyCorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
