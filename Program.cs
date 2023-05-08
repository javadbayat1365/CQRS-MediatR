using FluentValidation.AspNetCore;
using MediatR_CQRS;
using MediatR_CQRS.Controllers;
using MediatR_CQRS.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer("Data Source=.;Initial Catalog=MediatRCQRS;Integrated Security=True;TrustServerCertificate=True");
});


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ApplicationDbContext).Assembly);

builder.Services.AddMvc().AddFluentValidation(a => a.RegisterValidatorsFromAssemblyContaining<Program>());
builder.Services.AddMediatR(a => a.RegisterServicesFromAssembly(typeof(WeatherForecastController).Assembly));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseAuthorization();

app.MapControllers();

app.Run();
